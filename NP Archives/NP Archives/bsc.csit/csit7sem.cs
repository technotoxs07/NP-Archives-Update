using NP_Archives.bsc.csit.CSIT_7_sem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit
{
    public partial class csit7sem : Form
    {
        public csit7sem()
        {
            InitializeComponent();
        }

        private void csit7sem_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form? activeForm = null;

        private void btnadvancedjava_Click(object sender, EventArgs e)
        {
            gotoadvancedjava(new advancedjavaprogramming());
        }

        private void gotoadvancedjava(advancedjavaprogramming ChildForm)
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

        private void btndatwarehousinganddataminign_Click(object sender, EventArgs e)
        {
            gotodatawarehousinganddataminig(new datawarehousinganddatamining());
        }

        private void gotodatawarehousinganddataminig(datawarehousinganddatamining ChildForm)
        {
            throw new NotImplementedException(); if (activeForm != null)
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

        private void btnprincipalmanagement_Click(object sender, EventArgs e)
        {
            gotoprincipalofmanagement(new principalofmanagement());
        }

        private void gotoprincipalofmanagement(principalofmanagement ChildForm)
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

        private void btnprojectwork_Click(object sender, EventArgs e)
        {
            gotoprojectwork(new projectwork());
        }

        private void gotoprojectwork(projectwork ChildForm)
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
    }
}
