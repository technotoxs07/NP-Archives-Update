﻿namespace NP_Archives.bsc.csit.CSIT_6_sem
{
    partial class egovernance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backbtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textbookpage = new System.Windows.Forms.TabPage();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.modelquestionpage = new System.Windows.Forms.TabPage();
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabControl1.SuspendLayout();
            this.textbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.modelquestionpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::NP_Archives.Properties.Resources.back_to_32px;
            this.backbtn.Location = new System.Drawing.Point(8, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(46, 37);
            this.backbtn.TabIndex = 67;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.textbookpage);
            this.tabControl1.Controls.Add(this.modelquestionpage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(1, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 560);
            this.tabControl1.TabIndex = 66;
            // 
            // textbookpage
            // 
            this.textbookpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.textbookpage.Controls.Add(this.webView21);
            this.textbookpage.Location = new System.Drawing.Point(4, 28);
            this.textbookpage.Name = "textbookpage";
            this.textbookpage.Padding = new System.Windows.Forms.Padding(3);
            this.textbookpage.Size = new System.Drawing.Size(1202, 528);
            this.textbookpage.TabIndex = 0;
            this.textbookpage.Text = "Syllabus";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1204, 528);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // modelquestionpage
            // 
            this.modelquestionpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.modelquestionpage.Controls.Add(this.webView22);
            this.modelquestionpage.Location = new System.Drawing.Point(4, 28);
            this.modelquestionpage.Name = "modelquestionpage";
            this.modelquestionpage.Padding = new System.Windows.Forms.Padding(3);
            this.modelquestionpage.Size = new System.Drawing.Size(1202, 525);
            this.modelquestionpage.TabIndex = 1;
            this.modelquestionpage.Text = "Notes";
            // 
            // webView22
            // 
            this.webView22.AllowExternalDrop = true;
            this.webView22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView22.CreationProperties = null;
            this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView22.Location = new System.Drawing.Point(0, 0);
            this.webView22.Name = "webView22";
            this.webView22.Size = new System.Drawing.Size(1204, 525);
            this.webView22.TabIndex = 1;
            this.webView22.ZoomFactor = 1D;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webView23);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1202, 528);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Exam Question";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webView23
            // 
            this.webView23.AllowExternalDrop = true;
            this.webView23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.webView23.CreationProperties = null;
            this.webView23.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView23.Location = new System.Drawing.Point(0, 0);
            this.webView23.Name = "webView23";
            this.webView23.Size = new System.Drawing.Size(1204, 528);
            this.webView23.TabIndex = 1;
            this.webView23.ZoomFactor = 1D;
            // 
            // egovernance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1213, 608);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "egovernance";
            this.Text = "egovernance";
            this.Load += new System.EventHandler(this.egovernance_Load);
            this.tabControl1.ResumeLayout(false);
            this.textbookpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.modelquestionpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button backbtn;
        private TabControl tabControl1;
        private TabPage textbookpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TabPage modelquestionpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private TabPage tabPage1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
    }
}