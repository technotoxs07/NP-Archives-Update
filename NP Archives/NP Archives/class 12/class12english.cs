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
    public partial class class12english : Form
    {
        public class12english()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=11TIXpOuSXJ4mSe9FD86bp-ewiugxYPWo");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=101hF4nalVguGYovAB8So24kL3o7jdO0t");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1k7IslE23ubIk-KWbC0HazQ3LCymUklO_");
        }

        private void class12english_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
