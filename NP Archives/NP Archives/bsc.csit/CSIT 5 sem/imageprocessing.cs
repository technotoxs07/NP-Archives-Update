using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_5_sem
{
    public partial class imageprocessing : Form
    {
        public imageprocessing()
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
            await webView25.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1-qhuu5lngjNPQBkjCVrdrxQxr9qTurHe");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=17hYDsX1YnjFqa-9mVcp5UkX0mkZLXTkg");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1gtWKAVw5hFnGPqq40LtfxOVTe5rFfp96");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1AqZHVkwbMiB9TbDBELG8ZkhQOq-yu_h5");
            webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Pq-9rR6oQsdz4WI3XMGZFg5OkrAikeXd");
        }

        private void imageprocessing_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
