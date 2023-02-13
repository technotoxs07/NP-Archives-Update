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
    public partial class class9hpe : Form
    {
        public class9hpe()
        {
            InitializeComponent();
        }

        private void class9hpe_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView22.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1VEXbgiGumLGHYCt0BhgLP74Hsc6QU-7q");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
