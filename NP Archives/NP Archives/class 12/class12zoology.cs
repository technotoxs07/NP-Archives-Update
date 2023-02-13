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
    public partial class class12zoology : Form
    {
        public class12zoology()
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
            

        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1I0i9FduLGZIZXPi3ifjH6Aq0QG65lSGj");
           
        }

        private void class12zoology_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
