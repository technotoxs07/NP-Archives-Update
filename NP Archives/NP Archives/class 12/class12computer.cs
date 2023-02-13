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
    public partial class class12computer : Form
    {
        public class12computer()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1DYzoTHQcphQe4KHYq3HvNmx2kEbtJQJa");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1pLeS11pELi8yTrs_HDHAXd5UhIViVq12");
        }

        private void class12computer_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
