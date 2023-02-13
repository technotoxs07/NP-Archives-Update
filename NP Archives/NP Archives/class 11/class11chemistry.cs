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
    public partial class class11chemistry : Form
    {
        public class11chemistry()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1vLnM2E1nrs6g3NuyGdFESo5_3prWvSe0");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1hFet7DZnQNW1-I-fa2zvr1pgxzU5M3va");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1rCJUjfN6fxE-rev8tZv7_Gndy94DZU5L");
        }

        private void class11chemistry_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
