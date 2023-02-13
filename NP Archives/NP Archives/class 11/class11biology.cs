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
    public partial class class11biology : Form
    {
        public class11biology()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1rR2LMwQL1mCYKz74WFa7Foz2t4vKv2D5");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1AJLCkNmSZYonRe3BvksRAYYQHGOGTLH5");
        }

        private void class11biology_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
