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
    public partial class multimediacomputing : Form
    {
        public multimediacomputing()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1OTLZEtEn-HIV323Mzlupv7ESn3C9snkU");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=19GVaB_fH9EAHCjKsGn9E2w9_V-c2rqSA");

        }
        private void multimediacomputing_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
