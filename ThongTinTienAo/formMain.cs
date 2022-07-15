using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CoinGecko.Clients;
using System.Net.Http;

namespace ThongTinTienAo
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private  void button1_Click(object sender, EventArgs e)
        {

            
        }

        private async void tmrUpdateTop3_Tick(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings();

            PingClient pingClient = new PingClient(httpClient, serializerSettings);
            SimpleClient simpleClient = new SimpleClient(httpClient, serializerSettings);

            try
            {
                // Check CoinGecko API status
                if ((await pingClient.GetPingAsync()).GeckoSays != string.Empty)
                {
                    // Getting current price of tether in usd
                    string ids = "tether";
                    string vsCurrencies = "usd";
                    lblCoinTop3.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["tether"]["usd"]).ToString();
                    // Getting current price of tether in usd
                    await Task.Delay(100); // (Probably should be longer...)

                    ids = "ethereum";
                    vsCurrencies = "usd";
                    lblCoinTop2.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["ethereum"]["usd"]).ToString();
                    await Task.Delay(100); // (Probably should be longer...)

                    // Getting current price of tether in usd
                    ids = "bitcoin";
                    vsCurrencies = "usd";
                    lblCoinTop1.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["bitcoin"]["usd"]).ToString();
                    await Task.Delay(100); // (Probably should be longer...)
                }
            }
            catch
            {
                await Task.Delay(100);
            }
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings();

            PingClient pingClient = new PingClient(httpClient, serializerSettings);
            SimpleClient simpleClient = new SimpleClient(httpClient, serializerSettings);
            CoinGeckoClient coinClient = new CoinGeckoClient(httpClient, serializerSettings);

            lblGiaTien.Text = "Đang tìm.....";
            try
            {
                // Check CoinGecko API status
                if ((await pingClient.GetPingAsync()).GeckoSays != string.Empty)
                {
                    try
                    {
                        string ids = tbxNameCoin.Text;
                        string vsCurrencies = "usd";
                        lblGiaTien.Text = "Giá của đồng tiền " + ids + ": " +
                            ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))[ids]["usd"]).ToString()
                            + "$";
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm thấy đồng tiền, có lỗi xảy ra!");
                    }
                }
            }
            catch
            {

            }
        }

        private void btnDoThi_Click(object sender, EventArgs e)
        {
            if(lblGiaTien.Text.Length > 30)
            {
                formGraph fr = new formGraph(tbxNameCoin.Text);
                fr.Show();
                
            }    
            else
            {
                MessageBox.Show("Chưa chọn đúng Coin");
            }    
        }
    }
}
