using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace USStockWatchlist {
    sealed class APIClient {
        public static APIClient shared = new APIClient();
        private readonly HttpClient httpClient;
        private readonly string apiKey = ""; // Assign your key.

        private APIClient() { httpClient = new HttpClient(); }

        public Action<String> didFetchOneLogo;

        public async Task<(List<Stock> stocks, List<string> failureSymbols)> FetchData(List<string> symbols) {
            string query = String.Join(",", symbols);
            string url = $"https://financialmodelingprep.com/api/v3/profile/{query.ToUpper()}?apikey={apiKey}";
            JArray jsonStocks = JArray.Parse(await httpClient.GetStringAsync(url));

            Dictionary<string, StockDTO> stockDTOs = new Dictionary<string, StockDTO>();

            foreach (JToken jsonStock in jsonStocks) {
                StockDTO stockDTO = JsonConvert.DeserializeObject<StockDTO>(jsonStock.ToString());
                stockDTOs[stockDTO.Symbol] = stockDTO;
            }

            Dictionary<string, Bitmap> logos = await FetchLogos(symbols);
            //Dictionary<string, Bitmap> logos = await FetchLogosSync(symbols);
            List<Stock> stocks = new List<Stock>();
            List<string> failureSymbols = new List<string>();

            foreach (string symbol in symbols) {
                if (!stockDTOs.ContainsKey(symbol)) {
                    failureSymbols.Add(symbol); continue;
                }
                stocks.Add(new Stock(stockDTOs[symbol], logos[symbol]));
            }

            return (stocks, failureSymbols);
        }

        private async Task<Dictionary<string, Bitmap>> FetchLogos(List<string> symbols) {
            List<Task<Bitmap>> tasks = new List<Task<Bitmap>>();

            foreach (var symbol in symbols) {
                string url = $"https://financialmodelingprep.com/image-stock/{symbol.ToUpper()}.png";

                Task<Bitmap> task = Task<Bitmap>.Run(async () => {
                    try {
                        var stream = await new WebClient().OpenReadTaskAsync(new Uri(url));
                        didFetchOneLogo(symbol);
                        return new Bitmap(stream);
                    }
                    catch (Exception ex) {
                        Console.WriteLine(symbol + " error: " + ex.ToString());
                        return null;
                    }
                });
                tasks.Add(task);
            }
            var result = await Task.WhenAll(tasks);

            Dictionary<string, Bitmap> logos = new Dictionary<string, Bitmap>();
            Enumerable.Range(0, symbols.Count).ToList()
                .ForEach(i => logos[symbols[i]] = result[i]);

            return logos;
        }

        // 同期的にロゴを取得する関数（並列処理とパフォーマンス比較のため）
        private async Task<Dictionary<string, Bitmap>> FetchLogosSync(List<string> symbols) {
            List<Bitmap> bitmaps = new List<Bitmap>();

            foreach (var symbol in symbols) {
                string url = $"https://financialmodelingprep.com/image-stock/{symbol.ToUpper()}.png";

                try {
                    var stream = await new WebClient().OpenReadTaskAsync(new Uri(url));
                    didFetchOneLogo(symbol);
                    bitmaps.Add(new Bitmap(stream));
                }
                catch (Exception ex) {
                    Console.WriteLine(symbol + " error: " + ex.ToString());
                    bitmaps.Add(null);
                }
            }

            Dictionary<string, Bitmap> logos = new Dictionary<string, Bitmap>();
            Enumerable.Range(0, symbols.Count).ToList()
                .ForEach(i => logos[symbols[i]] = bitmaps[i]);

            return logos;
        }
    }
}
