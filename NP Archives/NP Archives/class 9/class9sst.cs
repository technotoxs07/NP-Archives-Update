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
    public partial class class9sst : Form
    {
        public class9sst()
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
            await webView23.EnsureCoreWebView2Async(null); ;
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Ay70E4oPCTNvcQ5yZG3wrBVN-Q0ygaGR");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1_VRmfTfb5gynhufhNeotEFLzZPATnvZI");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1nX4L9hwejEQp2Ea1bHW_rfLvTvctifdX");
        }

        private void class9sst_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
