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
    public partial class webtechnology : Form
    {
        public webtechnology()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1wJYSgU38PbJOhmMhe5FO_N_1AT6nAkZ4");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1RxWpQB9hXFMRj7IbkZMNNgLu14AuepaC");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1wo7ZpwT52A-O_gzai4fnJJD4DGoD_BpG");
        }

        private void webtechnology_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
