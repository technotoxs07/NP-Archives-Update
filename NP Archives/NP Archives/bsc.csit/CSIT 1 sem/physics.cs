using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_1_sem
{
    public partial class physics : Form
    {
        public physics()
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
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1k3RBQ9BvwxC1jZh9XwWAW802ln6YXoXi");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1I7W0IaTjnX40rSCuEj9bfOqbxnwQnHxp");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1dKmeOYpp2rN0SFx_0vS4NWkqe1lyXBer");
        }

        private void physics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
