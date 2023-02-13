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
    public partial class class9nepali : Form
    {
        public class9nepali()
        {
            InitializeComponent();
        }

        private void webView22_Click(object sender, EventArgs e)
        {

        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1dOyeKtNCTyVqTxgLJDh76gnmm5KLe-HR");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1rKFMbUjJZHE2zR5OA9sYZ0SolvJpq2Z8");
        }

        private void class9nepali_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
