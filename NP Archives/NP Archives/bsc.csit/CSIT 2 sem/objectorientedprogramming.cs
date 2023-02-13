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
    public partial class objectorientedprogramming : Form
    {
        public objectorientedprogramming()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1D6hHobCvzCQzymg0s8iHVVTMi7EipoXy");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=167YhNqiBQs1MVIDYAbXERrlI4udEB9md");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1MbVojS9-n9T_iQ4bDSBFpBuaQx1C-3xl");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1GUBR7Dh5pcTNV6JYvlCjSOM7ceGHyUhL");
            webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=12I8ZT8IIrsYbq8Bd_fzgVRPqmJ6feHiw");
        }

        private void objectorientedprogramming_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
