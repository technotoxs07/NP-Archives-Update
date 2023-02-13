using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_5_sem
{
    public partial class wirelessnetworking : Form
    {
        public wirelessnetworking()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
            await webView23.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1NJTjVnemDk4-aUjyHuum0onnSA2l7qXu");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1-YRw8fYvEyDEoSNmBs2TxdVLpg0p9Vvt");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1wiTjNSKs0iIHdARrhDciHUGly3pkLiBy");
        }

        private void wirelessnetworking_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
