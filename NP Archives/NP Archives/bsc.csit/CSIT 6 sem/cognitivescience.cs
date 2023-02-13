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
    public partial class cognitivescience : Form
    {
        public cognitivescience()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Kc7sfpiYG6tdtG-KHHJVLiepd7hgtdmH");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1W1bDyP0vgZ0dBah4sfylKvHUc3XXDEcO");
        }

        private void cognitivescience_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
