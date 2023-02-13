using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_11
{
    public partial class class11nepali : Form
    {
        public class11nepali()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Q51SgtcNc1pj1oQYjM48-KOpaif3MC10");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1j6H4kZZbUq7HzBn0B5njNaEk5wIy0JId");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1PXSuBVeYyTrH_CxcG0ckaqwEI11Z7u6r");
              
        }
        private void class11nepali_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
