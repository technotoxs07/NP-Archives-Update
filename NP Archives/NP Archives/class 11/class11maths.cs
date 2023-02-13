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
    public partial class class11maths : Form
    {
        public class11maths()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void class11maths_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
            await webView23.EnsureCoreWebView2Async(null);
            await webView24.EnsureCoreWebView2Async(null);
            await webView25.EnsureCoreWebView2Async(null);
            await webView26.EnsureCoreWebView2Async(null);
            await webView27.EnsureCoreWebView2Async(null); 
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1R7Etn-Q_P-kp5TlCJydzzWwZ2nJJtnjN");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1LHKjIf5rtwyiKkyS8FSovLtGuOqIkXat");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1H3JlMts7OFtu6pg_Tednd9JsdOrvtBcP");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1KueJ35v46XMZPUMEel593s5HU2FtMFZl");
            webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1x3z67nOcX3Q5XfwBfSBBoXclDOcJqw9Y");
            webView26.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1y4AUioQB6qoS9tRkYAUPVCXgp4l9bwaD");
            webView27.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1nQ7PqeHmeiNq99EFkS3j-6jBuTpicTN_");
        }

    }
}
