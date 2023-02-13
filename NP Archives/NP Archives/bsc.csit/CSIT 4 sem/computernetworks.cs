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
    public partial class computernetworks : Form
    {
        public computernetworks()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=11zGtPUMuxxq3r2XouDllEBnlrfe3xRSB");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1HrQSH2Ii3ZEmpi4apQrOtQhE26XNfGb5");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1hhV8xYr3_xMNg1ixSwZPWtxQqqkCv-yA");
        }

        private void computernetworks_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
