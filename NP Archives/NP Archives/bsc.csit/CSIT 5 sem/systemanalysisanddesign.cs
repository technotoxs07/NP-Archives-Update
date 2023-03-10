using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_5_sem
{
    public partial class systemanalysisanddesign : Form
    {
        public systemanalysisanddesign()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1MyNSa8T_K8Z5kdBKgt_QTLx-hK2Pcuoi");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1_eBBdhZeIrXwdkr8wiJ12rWl9U47xHW4");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1TCqgJ3dhlu6NflJEzQavBASHq-C0bWfY");
        }
        private void systemanalysisanddesign_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
