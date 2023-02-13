using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_5_sem
{
    public partial class cryptography : Form
    {
        public cryptography()
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
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1uvReCoFykNuSD7sN9kEWVLok3BmqhgMS");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=11eNYLIwsAqZ307kt0H-lMtdd1_FqdZIC");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1CG_fUNyHNFrOM_XP3Y-B6ZVHba0OMlZb");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1nBYoSM6HmeMsxQQaxVLYtIby3q43SlTo");
                
        }

        private void cryptography_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
