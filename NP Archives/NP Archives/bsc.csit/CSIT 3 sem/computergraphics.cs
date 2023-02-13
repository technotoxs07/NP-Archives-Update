using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_3_sem
{
    public partial class computergraphics : Form
    {
        public computergraphics()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mKDRHmPPerdajjeLzQ7aX7wWAo4_UmD3");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mF0R-f99G-qa-LN2YHsCeGO01L7_osof");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1giEeZNoK0Pl7BsjXtg6ATll3jyfGOsLQ");
        }

        private void computergraphics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
