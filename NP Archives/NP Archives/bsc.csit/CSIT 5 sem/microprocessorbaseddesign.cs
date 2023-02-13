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
    public partial class microprocessorbaseddesign : Form
    {
        public microprocessorbaseddesign()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1DrgPkc4kFpnOz-1oVdQboiq-frVbIyDi");

        }
        private void microprocessorbaseddesign_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
