using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_1_sem
{
    public partial class cprogramming : Form
    {
        public cprogramming()
        {
            InitializeComponent();
        }

        private void cprogramming_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
            await webView23.EnsureCoreWebView2Async(null);
            await webView24.EnsureCoreWebView2Async(null);
            await webView25.EnsureCoreWebView2Async(null);
            await webView26.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1LLf4Df6kBMSZMPANBfbRmrgl9BnMDOve");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1jkoDNd_vstxR4uW_4EAP8Fda2fmxU7XY");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1hx25554YR3i0hl4gyIC9NvM4p1u4vNPs");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mDsUcztjwxB41gGXZ90brbkLRBdtivLA");
            webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1_Mc_Wl2JNYXC7bGPlBe7KMTUE_yH5eo9");
            webView26.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1hdzFcR5mSUFxcqjkF_cw4Gf267EGPetc");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webView23_Click(object sender, EventArgs e)
        {

        }

        private void webView25_Click(object sender, EventArgs e)
        {

        }
    }
}
