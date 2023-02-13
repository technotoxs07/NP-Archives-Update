using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_4_sem
{
    public partial class operatingsystem : Form
    {
        public operatingsystem()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=16SZ9FWmENME_Ef1Qs343ysA3gTs_y4_m");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1A5Pb2CqDrkCk_bOShDFfaFj7odOSscUW");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=11DOulvEsOZFWPzUEDXk3RHbtisa7D29W");
        }

        private void operatingsystem_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
