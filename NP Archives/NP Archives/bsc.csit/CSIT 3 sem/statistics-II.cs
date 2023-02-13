using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_3_sem
{
    public partial class statistics_II : Form
    {
        public statistics_II()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Saik9SNtSHbzrjGAQ6J4gmCZzySBYeIg");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1BqppWXq014Nw2hAxJ4Y4yMIegAcXmL7I");
        }

        private void statistics_II_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
