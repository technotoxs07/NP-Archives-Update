using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_12
{
    public partial class class12chemistry : Form
    {
        public class12chemistry()
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
            await webView24.EnsureCoreWebView2Async(null);
           
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1TLvDoql4Y3cwxi8tXM2AqHpTId6BswQP");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1MVykyY7nMEjP_HsnC1XJvAl0bUPcJJ5z");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1lBY1YawEA_D6amPCypp3BzD34dV7g9kJ");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1hDX156AQBWzPfGOPsvde0kb3K7gwC89A");
           
        }

        private void class12chemistry_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
