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
    public partial class class12maths : Form
    {
        public class12maths()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1i610vfe-RC7h7Bl4eAi4pGUP9323UWur");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=14NaZm7zl8RgLr6uOTMn-4QdWu6tOWppN");
        }

        private void class12maths_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
