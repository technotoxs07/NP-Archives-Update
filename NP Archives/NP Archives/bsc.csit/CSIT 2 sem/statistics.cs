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
    public partial class statistics : Form
    {
        public statistics()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1esYBJ3QzCZu4F4Hl59f2pc3YopvVn29I");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1XlPD0iZA1CPTE7VvpJRpS1sxKuWLmUxC");
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
