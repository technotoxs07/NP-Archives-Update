using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_3_sem
{
    public partial class numericalmethod : Form
    {
        public numericalmethod()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1fXV5jtyQ-iOm2qJbiBPCIxKG40A1gqP_");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1SK1p2go4bxzk3ODtSEYNvWeHnJwfDxna");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1WDP7jQHQSY1_zeATxPM9xbGak15fLi0s");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1CpkTn3fhkmRShLOSoB6T1k1VaVLW2pVF");
        }


        private void numericalmethod_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
