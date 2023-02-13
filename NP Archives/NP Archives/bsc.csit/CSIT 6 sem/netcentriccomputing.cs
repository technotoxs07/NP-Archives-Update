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
    public partial class netcentriccomputing : Form
    {
        public netcentriccomputing()
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
            await webView24.EnsureCoreWebView2Async(null);
            await webView25.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1PtepNCqAZU5M9Ojic38WnN7M-8QK5q_y");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1pG2Bphj-5ZLHA6UNAotimcSbHPYRLmyA");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1op1J9rJvCR3eGJhVU-Dy-qPvTobwJ8pi");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1qaZSM3LeFt5Hu5k3s7Xewm5-L8rS0qKh");
            webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mLdxNoPI9sqTDC2XCTsBKbHkJlfbQ8tK");
        }

        private void netcentriccomputing_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
