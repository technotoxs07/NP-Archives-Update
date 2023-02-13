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
    public partial class class11physics : Form
    {
        public class11physics()
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
            await webView25.EnsureCoreWebView2Async(null);
            await webView26.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1nFDPOgpndwMQCLDeBmhjDXQ3OSJL40ML");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1JA7Sy_E9NusgfpH59eiDmRJ-cagNcuTZ");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=13OT5LVVtKyGmYX2YZwhEh8oDTmsODRTn");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1IZ-ejnJhQcaZWBXHs6xZgwySk0lopz85");
            webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1HCAwSbCgLT38gKf61ITV9dxoieXP8I8E");
            webView26.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1E77-d_2Qpy6UIdgXuonW8s1VQaLCt82q");
        }

        private void class11physics_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
