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
    public partial class class12physics : Form
    {
        public class12physics()
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
            await webView24.EnsureCoreWebView2Async(null);
            

        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1YOItaeTAsNMWr6sMrntRvvAVThb4NY2K");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1K_52QP0PesN1tk-fcAski66R5aqKCfEA");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1uDI_GT8b2StvsuDHn540nj4rFHM8lOi0");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Eev3HRCMM0vfQQurVqjB33qFS3L_QriZ");
        }

        private void class12physics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
