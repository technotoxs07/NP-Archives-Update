using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_8_sem
{
    public partial class internship : Form
    {
        public internship()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1bT3nD34Fw3fWTmVnnKDXxqxEw-bN6oU7");
        }
        private void internship_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
