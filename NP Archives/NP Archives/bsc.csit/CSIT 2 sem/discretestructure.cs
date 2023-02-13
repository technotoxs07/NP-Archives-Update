using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_2_sem
{
    public partial class discretestructure : Form
    {
        public discretestructure()
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
            await webView24.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1ad1bTbfm1-55sOsiKn-a_sC52cOGdKcS");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1CxQZXnd3jrd24IWtIad3eJZ9g_L-yJ35");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1w-HYDNhrX3a_bZjmUrJkbBdfILgFIwJA");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1f5xJCwxZiHSbTDNwW_iu4jFY38nmGwvu");
        }
        private void discretestructure_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
