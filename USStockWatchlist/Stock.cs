using Newtonsoft.Json;
using System.Drawing;

namespace USStockWatchlist {
    struct Stock {
        public string Symbol { get; }
        public string CompanyName { get; }
        public double CurrentPrice { get; }
        public double PercentageChange { get; }
        public Bitmap Logo { get; }

        public Stock(StockDTO stockDTO, Bitmap logo) {
            this.Symbol = stockDTO.Symbol;
            this.CompanyName = stockDTO.Name;
            this.CurrentPrice = stockDTO.Price;
            this.PercentageChange = stockDTO.Changes / (stockDTO.Price - stockDTO.Changes) * 100;
            this.Logo = logo;
        }
    }

    [JsonObject]
    struct StockDTO {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("companyName")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("changes")]
        public double Changes { get; set; }
    }
}


/*
MSFT
AAPL
GOOG
AMZN
KO
PEP
JNJ
SBUX
MCD
NKE
TSLA
NVDA
ADBE
NFLX
TWTR
DOW
HD
WMT
PG
BA
UNH
VZ
CAT
AMGN
CRM
MRK
HON
CSCO
DIS
IBM
V
AXP
GS
TRV
INTC
CVX
MMM
WBA
JPM
T
 */

/*
MSFT
AAPL
GOOG
TWTR
KO
MCD
SBUX
NKE
 */