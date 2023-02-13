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
    public partial class digitallogics : Form
    {
        public digitallogics()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void webView22_Click(object sender, EventArgs e)
        {

        }

        private void webView23_Click(object sender, EventArgs e)
        {

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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=15dxKsbyb9wvYgAG_HUxAfQcwcLGPmJe7");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1SaDxchhB67WmSmXCVvfl_7wxjJZdOKFs");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1gkdiBtvX1B2ynnDpWD1cBvoUjcfM9qkg");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1bpdF20YxRnJv4HL585CN_VrlisEfabEU");
        }

        private void digitallogics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
