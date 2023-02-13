using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_6_sem
{
    public partial class compilerdesignandcontruction : Form
    {
        public compilerdesignandcontruction()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1o98GZYqq50o7kFtKOdZJW5v2NJzTEBkR");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1S_iHXJAsgArvgahc-5AFAlBHOpypbfXw");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1-p9wlU4t994L7Ag5eIhdrKBl857YQrnN");
        }

        private void compilerdesignandcontruction_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
