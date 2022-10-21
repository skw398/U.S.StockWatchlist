using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace USStockWatchlist {
    sealed public partial class MainForm : Form {
        private StockDataSource stockDataSource;
        private SortType selectedSortType = SortType.custom;
        private readonly string path = @"..\..\SymbolsTextBox.txt";

        private bool IsLoading {
            set {
                loadButton.Enabled = !value;
                sortTypesGroupBox.Enabled = !value;
                symbolsTextBox.Enabled = !value;
                progressBar.Visible = value;
            }
        }

        public MainForm() {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(path)) {
                symbolsTextBox.Text = sr.ReadToEnd();
            }

            APIClient.shared.didFetchOneLogo = symbol => {
                // UIスレッドで実行
                Invoke((Action)(() => {
                    progressBar.Value++;
                    statusLabel.Text = symbol + " is Loaded";
                }));
            };
        }

        private async void LoadButtonDidClick(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(symbolsTextBox.Text.Trim())) return;

            await Fetch();

            using (StreamWriter writer = new StreamWriter(path, false)) {
                writer.WriteLine(symbolsTextBox.Text);
            }
        }

        private void SortTypeRadioButtonDidClick(object sender, EventArgs e) {
            SortType[] sortTypes = (SortType[])Enum.GetValues(typeof(SortType));
            RadioButton[] radioButtons = { customRadioButton,
                                           AlphabeticalRadioButton,
                                           PercentageChangeRadioButton };

            int clickedButtonIndex = Array.IndexOf(radioButtons, (RadioButton)sender);
            selectedSortType= sortTypes[clickedButtonIndex];

            if (stockDataSource == null) { return; }

            stockDataSource.Sort(selectedSortType);
            UpdateGridView();
        }

        private List<string> CreateSymbolsListFromTextFieldText() {
            return symbolsTextBox.Text
                .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(symbol => symbol.ToUpper())
                .Select(symbol => symbol.Trim())
                .Where(symbol => !string.IsNullOrEmpty(symbol))
                .ToList();
        }

        private List<string> FindDuplicatedSymbols(List<string> symbols) {
            return symbols
                .GroupBy(symbol => symbol)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .ToList();
        }

        private void ShowAlertWithEnumeratingSymbols(List<string> symbols, string title) {
            string text = title + "\r\n";
            symbols.ForEach(symbol => text += "\r\n" + "- " + symbol);
            MessageBox.Show(text,
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        private async Task Fetch() {
            IsLoading = true;
            try {
                stocksGridView.Rows.Clear();
                stockDataSource = null;

                List<string> symbols = CreateSymbolsListFromTextFieldText();
                List<string> duplicatedSymbols = FindDuplicatedSymbols(symbols);

                if (duplicatedSymbols.Count > 0) {
                    ShowAlertWithEnumeratingSymbols(duplicatedSymbols,
                                                    title: "Remove duplicated symbols and start loading.");
                    symbols = symbols.Distinct().ToList();
                }

                ConfigureProgressBar(symbols);

                var (stocks, failureSymbols) = await APIClient.shared.FetchData(symbols);

                stockDataSource = new StockDataSource(symbols, stocks);
                stockDataSource.Sort(selectedSortType);

                if (failureSymbols.Count > 0) {
                    ShowAlertWithEnumeratingSymbols(failureSymbols,
                                                    title: "The following symbols failed to load.");
                    progressBar.Value = progressBar.Maximum;
                }

                // 遅れて描画されるprogressBarのアニメーションの完了を待つ
                await Task.Delay(500);

                int succeededSymbolsCount = symbols.Count - failureSymbols.Count;
                statusLabel.Text = succeededSymbolsCount + " stocks loaded.";
                FormatTextBoxText(symbols, failureSymbols);
                UpdateGridView();
            } catch (Exception ex) {
                Console.WriteLine("error: " + ex);
                MessageBox.Show("Failed to Load",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            IsLoading = false;
        }

        private void FormatTextBoxText(List<string> symbols, List<string> failureSymbols) {
            symbolsTextBox.Text = "";
            symbols.ForEach(symbol => {
                string newSymbol = symbol;
                if (failureSymbols.Count > 0) {
                    foreach (string failureSymbol in failureSymbols) {
                        if (symbol == failureSymbol) { newSymbol = "*" + symbol; break; }
                    }
                }
                symbolsTextBox.Text += newSymbol;
                if (symbol != symbols.Last()) { symbolsTextBox.Text += "\r\n"; }
            });
        }

        private void UpdateGridView() {
            stocksGridView.Rows.Clear();

            for (int i = 0; i < stockDataSource.Stocks.Count; i++) {
                Stock stock = stockDataSource.Stocks[i];

                string percentageChangeStr = stock.PercentageChange >= 0
                                             ? "+" + stock.PercentageChange.ToString("0.00") + "%"
                                             : stock.PercentageChange.ToString("0.00") + "%";

                stocksGridView.Rows.Add(stock.Logo,
                                        stock.Symbol,
                                        stock.CompanyName,
                                        stock.CurrentPrice.ToString("0.00"),
                                        percentageChangeStr);

                stocksGridView[4, i].Style.ForeColor = stock.PercentageChange >= 0
                                                       ? Color.Green
                                                       : Color.Red;
            };
        }

        private void ConfigureProgressBar(List<string> symbols) {
            progressBar.Value = 0;
            progressBar.Maximum = symbols.Count;
        }

        // GridViewを選択不可
        private void GridViewSelectionChanged(object sender, EventArgs e) {
            stocksGridView.ClearSelection();
        }

        private void LinkLabelDidClick(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://site.financialmodelingprep.com/developer/docs/");
        }
    }
}