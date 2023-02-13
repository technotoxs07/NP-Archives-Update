using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_6_sem
{
    public partial class softwareengineering : Form
    {
        public softwareengineering()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1i5S1v3B6n-LTIE5-ICpN0lkjvkQVBGgM");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1lDiNxHVnTPxk167kQS8QmA3zOPEsNiys");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1cvtnhLFxPxdktxEYam7alZNZq2ayQIak");
        }

        private void softwareengineering_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
