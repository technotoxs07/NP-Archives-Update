using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_7_sem
{
    public partial class datawarehousinganddatamining : Form
    {
        public datawarehousinganddatamining()
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
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1-VsMCEsc9LZAnVuAfABY-XuOUWh6Zmyd");
        }

        private void datawarehousinganddatamining_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
