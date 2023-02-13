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
    public partial class microprocessor : Form
    {
        public microprocessor()
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
            await webView25.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1tLunm9gg4id6VaXByWj-loNSf2w5XRkB");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1A4GOVrZP8RurKqh7Oh7N0LxVhnXd9gn-");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1w_YplWNhht_5n577XSRLTLtJi32s-Ve5");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1PNCfrUD1hIq50GW4pO0pFCy-64nzaxPH");
            webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=11abuqw4-ovd8Tf2ZcZ7GGJqWlpnfQOiv");
        }



        private void webView23_Click(object sender, EventArgs e)
        {

        }

        private void microprocessor_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
