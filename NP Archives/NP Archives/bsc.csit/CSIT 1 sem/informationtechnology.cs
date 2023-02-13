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
    public partial class informationtechnology : Form
    {
        public informationtechnology()
        {
            InitializeComponent();
        }

        private void informationtechnology_Load(object sender, EventArgs e)
        {
            InitBrowser();
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1AJGRxodHfgCCf_vkvcFgxjaZD9xd9Tan");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=16HlBRZDJCVE4ak5lXw5H8NtwMA9lcIXd");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1q5DBGzOAlesL-SqPVpr4Azl3F3pSX-YN");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
