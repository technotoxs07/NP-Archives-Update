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
    public partial class class10hpe : Form
    {
        public class10hpe()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1cDAtPMZJLu-BQVYELhxEmv9HZ6KhLa03");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=14xeD2gGRo3uB4TW4pfkiCYy0zBxK5cvC");
        }

        private void class10hpe_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
