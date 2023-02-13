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
    public partial class artificialintelligence : Form
    {
        public artificialintelligence()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=14RRKxqVNsIT4kJTkRZemQOILBRQBsoi0");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mvjAKyTjqaO58Qbv-EmUeBWdQlJi_jX_");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1-4kDD2cpSIMWEpLH8JOHiykAAjePc1oq");
        }

        private void artificialintelligence_Load(object sender, EventArgs e)
        {
            InitBrowser();
;        }
    }
}
