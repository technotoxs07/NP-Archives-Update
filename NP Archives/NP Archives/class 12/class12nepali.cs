using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_12
{
    public partial class class12nepali : Form
    {
        public class12nepali()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=18IwRiAz8JWTZtJcjE_l40PIOyQGPYzGW");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1ijf8pBaSWRQtRN-TwNZKvoyLDqlkU-ch");
        }

        private void class12nepali_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
