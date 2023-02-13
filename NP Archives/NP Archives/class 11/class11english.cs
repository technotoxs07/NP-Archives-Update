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
    public partial class class11english : Form
    {
        public class11english()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void class11english_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1SpI9sj0rfCpy_HNLHFUi-hED8nZXqvBN");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Of-vaN8DWRuibrrtYNcrICW9GbL5Ehgf");
        }
    }
}
