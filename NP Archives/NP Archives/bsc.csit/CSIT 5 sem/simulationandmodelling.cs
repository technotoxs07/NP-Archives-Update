using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_5_sem
{
    public partial class simulationandmodelling : Form
    {
        public simulationandmodelling()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1q2GhDbYzrT9T-w8FzBAwT7UCGire3dWH");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1N3amws1HIwojEllx5Qd5EZ5IAXwULdGr");
            webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1fMfMn3lbhR19dzq9Lgcy9PPzIrKHaeeU");
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1X6eNWoXzNNlsK0JQPy4K8g1Cvl8FM76u");
        }

        private void simulationandmodelling_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
