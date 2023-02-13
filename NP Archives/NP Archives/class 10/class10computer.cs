using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_10
{
    public partial class class10computer : Form
    {
        public class10computer()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1ds1jhF7tnA5AxJkOGHuGfpPuxy20mlCT");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1joKqrkNSjxCKV_KirWEWMK6RsJcQybtF");
        }
        private void class10computer_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
