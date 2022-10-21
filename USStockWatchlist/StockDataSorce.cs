using System.Collections.Generic;
using System.Linq;

namespace USStockWatchlist {
    enum SortType { custom, alphabetical, percentageChange }

    sealed class StockDataSource {
        private readonly List<string> symbols;
        public List<Stock> Stocks { get; private set; }

        public StockDataSource(List<string> symbols, List<Stock> stocks) {
            this.symbols = symbols;
            this.Stocks = stocks;
        }

        public void Sort(SortType sortType) {
            switch (sortType) {
                case SortType.custom:
                    List<Stock> sortedStocks = new List<Stock>();
                    foreach (string symbol in symbols) {
                        sortedStocks.AddRange(Stocks.Where(stock => stock.Symbol == symbol));
                    }
                    Stocks = sortedStocks;
                    break;

                case SortType.alphabetical:
                    Stocks = Stocks
                        .OrderBy(stock => stock.Symbol)
                        .ToList();
                    break;

                case SortType.percentageChange:
                    Stocks = Stocks
                        .OrderByDescending(stock => stock.PercentageChange)
                        .ToList();
                    break;
            }
        }
    }
}
