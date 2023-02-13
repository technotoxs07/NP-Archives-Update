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
    public partial class theoryofcomputation : Form
    {
        public theoryofcomputation()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1wFLYMv2i9tc8kwHo4lbB0oOOwcY_qQv7");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1lkUv8892cBiosKhelhF9RTG2wisR9Qim");
        }

        private void theoryofcomputation_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
