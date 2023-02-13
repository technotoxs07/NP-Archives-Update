using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;


namespace NP_Archives
{
    public partial class class9english : Form
    {
        public class9english()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textbookpage_Click(object sender, EventArgs e)
        {
            /* string path = Path.Combine(Directory.GetCurrentDirectory(), "1852.pdf");
             Process P = new Process
             {
                 StartInfo = { FileName = "AcroRd32.exe", Arguments = path }
             };
             P.Start();
            */

            
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1qFcmQ7Thmttj8kbrhTQW6JDFa5KgfWhV");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Pe-Yekeh_5cnBrvlCVRiY9T2Ee9POl-R");
        }

        private void class9english_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
