using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CoinGecko.Clients;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Interfaces;
using CoinGecko.Parameters;

namespace ThongTinTienAo
{
    public partial class formGraph : Form
    {
        public formGraph(string nameCoin)
        {
            _client = CoinGeckoClient.Instance;
            _nameCoin = nameCoin;
            InitializeComponent();
        }

        private readonly ICoinGeckoClient _client;
        private readonly string _nameCoin;

        private void formGraph_Load(object sender, EventArgs e)
        {
            fillchart();
            chtCoin.Series[0].Name = _nameCoin;
            chtCoin.Series[0].ChartType = SeriesChartType.Column;

        }
        private static readonly DateTime epoch = new DateTime(1970, 1, 1);

        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }
        private async void fillchart()
        {
            var result = await _client.CoinsClient.GetMarketChartsByCoinId(_nameCoin, "usd", "max");
            foreach(var _ in result.Prices)
            {
                _[0] = _[0] / 1000;
                Console.Write(FromUnixTime((long)_[0]));
                Console.Write(", ");
                Console.WriteLine(_[1]);

                chtCoin.Series[0].Points.AddXY(FromUnixTime((long)_[0]).ToString().Substring(0,11),_[1]);
            }    
        }
    }
}
