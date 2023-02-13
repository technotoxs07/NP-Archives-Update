﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_7_sem
{
    public partial class advancedjavaprogramming : Form
    {
        public advancedjavaprogramming()
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1ME8b_boRkWWTx7F5yF5TCUyLYVaeXv-y");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1zcxQCShetuKiSMguZRrCFQC1JcnB2KJo");
        }

        private void advancedjavaprogramming_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
