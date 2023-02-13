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
    public partial class egovernance : Form
    {
        public egovernance()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1AlKWVfhlXFP5cuSyX2FDfklQE56e2tfC");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1kvBacmMzUKZO8OdxWnfuMMefOkZzMNJX");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1TV3ZP2VwIKIV_waKS0G2zWNClTgXaH6g");
        }

        private void egovernance_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
