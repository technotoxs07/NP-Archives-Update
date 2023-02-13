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
    public partial class class10sst : Form
    {
        public class10sst()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=16REGOu4zP8EI7DfI9oyv8Ermtvka5xKC");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mkub-tjb6V7gMERqUFX0-B10uYyMY9Pz");
        }

        private void class10sst_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
