using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_1_sem
{
    public partial class mathematics : Form
    {
        public mathematics()
        {
            InitializeComponent();
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1oN5hw-E6hecDwng0LgMG9JcvMPbmceE9");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1NQXU70jdSSBKtb9tynzU-So74HZphYoF");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=17JITvyRoPXaF5SQybWeWySSPsFpM8M1p");
        }
        private void mathematics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
