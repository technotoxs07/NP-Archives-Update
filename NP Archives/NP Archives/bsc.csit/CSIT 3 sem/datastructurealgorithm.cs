using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_3_sem
{
    public partial class datastructurealgorithm : Form
    {
        public datastructurealgorithm()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1kDMatUu6WjvQW4qe5eyoiJGrbBIhoqja");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1GZz-WIg63bZgy38igE2MS0QfEfDEHv2s");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1V1sX28diYqGmqt3mGljuAj0O5zRMb2Tq");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1VNpL4CjytGsPDFrpbZeA31-BMe6GusYG");
        }


        private void datastructurealgorithm_Load(object sender, EventArgs e)
        {
            InitBrowser();

        }
    }
}
