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
    public partial class class12biology : Form
    {
        public class12biology()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1xDbiZmKrZ5QsDS4j5v5qswfgoN8tQAj2");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1f8lfIAqDzPJjRJd1xvAvyAkM9pOGyKpe");
        }

        private void class12biology_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
