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
    public partial class class9maths : Form
    {
        public class9maths()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Zuwgy6OfXnmnV2nHC_O6kP7LIYNilf89");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1OBQzxvuhkg3ACzq7r5TJ4lDV0otI7-fC");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1IcoXHhf78VQE4WkBnaMfhiSO-_nxbLPN");
        }


        private void class9maths_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
