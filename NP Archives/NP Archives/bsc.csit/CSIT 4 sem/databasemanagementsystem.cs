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
    public partial class databasemanagementsystem : Form
    {
        public databasemanagementsystem()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1k-9gVxDcYAycqc10oapGmpU_lSaaTQu2");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1G4Ry678yPzlZ-eszBajBx7ji1O5kTXHX");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1wXLB96Hx4nRaoNWbYMwsHMX0FWI68xFx");
        }

        private void databasemanagementsystem_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
