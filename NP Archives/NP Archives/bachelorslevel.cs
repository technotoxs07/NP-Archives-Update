using HtmlAgilityPack;
using NP_Archives.bsc.csit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NP_Archives
{
    public partial class bachelorslevel : Form
    {
        public bachelorslevel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclass9hpe_Click(object sender, EventArgs e)
        {
            gotocsit5sem(new csit5sem());
        }

        private void gotocsit5sem(csit5sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private Form? activeForm = null;


        private void btnclass9computer_Click(object sender, EventArgs e)
        {
            gotocsit8sem(new csit8sem());
        }

        private void gotocsit8sem(csit8sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void bachelorslevel_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.google.com/");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void csit1stsem_Click(object sender, EventArgs e)
        {
            gotocsit1sem(new csit1sem());
        }

        private void gotocsit1sem(csit1sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void csit2ndsem_Click(object sender, EventArgs e)
        {
            gotocsit2sem(new csit2sem());
        }

        private void gotocsit2sem(csit2sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void csit3rdsem_Click(object sender, EventArgs e)
        {
            gotocsit3sem(new csit3sem());
        }

        private void gotocsit3sem(csit3sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void csit4thsem_Click(object sender, EventArgs e)
        {
            gotocsit4sem(new csit4sem());
        }

        private void gotocsit4sem(csit4sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void csit6thsem_Click(object sender, EventArgs e)
        {
            gotocsit6sem(new csit6sem());
        }

        private void gotocsit6sem(csit6sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void csit7thsem_Click(object sender, EventArgs e)
        {
            gotocsit7sem(new csit7sem());
        }

        private void gotocsit7sem(csit7sem ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        

        private void bca1sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());
        }

        private void bca2sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());

        }

        private void bca3sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());
        }

        private void bca4sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());
        }

        private void bca5sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());
        }

        private void bca6sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());
        }

        private void bca7sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());
        }

        private void bca8sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After 2nd Sem Exam. I Promise I will upload it", MessageBoxButtons.OK.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(textBox1.Text);

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                GetBotResponse();
                e.Handled = e.SuppressKeyPress = true; //This Code for Disabling Beep Sound On Enter Key
            }
        }

        private void GetBotResponse()
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(textBox1.Text);

            }
        }

        private async Task itnitied()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private async void browserinit()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.tuiost.edu.np/notice");
        }


        private void btnnews_Click(object sender, EventArgs e)
        {
            browserinit();
            //username();

        }

       /* private void username()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load("https://www.tuiost.edu.np/notices");
            var usertext = document.DocumentNode.SelectNodes("//*[@id=\"notices\"]/div/div[2]/ul/li[9]/featured-content").First().InnerText;
            textBox2.Text = usertext;
        }
       */

        
    }
}
