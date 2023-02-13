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
    public partial class class12botany : Form
    {
        public class12botany()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task initizated()
        {
            
            await webView24.EnsureCoreWebView2Async(null);


        }

        private async void InitBrowser()
        {
            await initizated();
           
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1VJ0kZJ17s-5FqOOpfFwAfiF7z6F_fkaz");
        }

        private void class12botany_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
