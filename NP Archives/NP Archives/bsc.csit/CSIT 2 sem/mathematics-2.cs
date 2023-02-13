using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_2_sem
{
    public partial class mathematics_2 : Form
    {
        public mathematics_2()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1jFWIppe4Y-ZTjNhZjkrTfdAw7NDTHeGJ");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1a05OL1wG7w8J7WjHvVURJaWxG_Wxd-pd");
        }

        private void mathematics_2_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
