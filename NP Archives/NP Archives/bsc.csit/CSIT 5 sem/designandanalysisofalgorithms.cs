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
    public partial class designandanalysisofalgorithms : Form
    {
        public designandanalysisofalgorithms()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=18G5cyrqrX5KmqEvNq-N27rCblPJzcbvL");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=16-yczksBL_AIv9_v-JHTomH503ZKt8Pp");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1E0WvYwpeCuEtetver5S5t4VPcNcs-w_X");
        }

        private void designandanalysisofalgorithms_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
