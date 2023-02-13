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
    public partial class technicalwriting : Form
    {
        public technicalwriting()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1af5UU_F4e6SYOfR5m5UqV8fWVUGaCpR7");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=111CdPx_Mmj2INJj6vD2fczrzqsm3zrQ3");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1WiLoukh5WLAsPb1zVYbPPfKcpdjydXny");
        }
        private void technicalwriting_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
