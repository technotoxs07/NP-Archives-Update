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
    public partial class automationandrobotics : Form
    {
        public automationandrobotics()
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
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=11-AizB4i4ffWSMF0bpe7Qslf6QVtqPrC");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1XpWCPFzNf5imrADaB4rnx6HU61KFtsGb");
        }
        private void automationandrobotics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
