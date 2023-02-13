using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives
{
    public partial class class10science : Form
    {
        public class10science()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1HjxOQJDBS1vg_GRPBu8p1yfFvRnVOttm");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1kb5S9vzhiExcDeFfzn0klHLUuePGCZHA");
        }

        private void class10science_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
