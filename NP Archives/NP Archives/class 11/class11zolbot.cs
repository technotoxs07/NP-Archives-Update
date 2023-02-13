using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_11
{
    public partial class class11zolbot : Form
    {
        public class11zolbot()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1_-qHyrHzz1umjmHMhSXDZbF_wQTIcVtq");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1ImEXj4sO_M7_-inB_Z669HbeD-PioHSy");
        }

        private void class11zolbot_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
