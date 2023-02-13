using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives
{
    public partial class class10english : Form
    {
        public class10english()
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
            await webView23.EnsureCoreWebView2Async(null); ;

        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1ci11jejXST4HFI942PUHdqVtUaBOpuw8");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1QY96my-P_fcYSREQNE8G8r6IBqio5JGh");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1lM0nxMaOIp6O3QVsjnqfYg2_4nj6QGqr");
        }

        private void class10english_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
