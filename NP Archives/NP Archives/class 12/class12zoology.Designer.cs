﻿namespace NP_Archives.class_12
{
    partial class class12zoology
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
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.practicalcopypage = new System.Windows.Forms.TabPage();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabControl1.SuspendLayout();
            this.practicalcopypage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Class 12 ZOOLOGY";
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::NP_Archives.Properties.Resources.back_to_32px;
            this.backbtn.Location = new System.Drawing.Point(8, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(46, 40);
            this.backbtn.TabIndex = 62;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.practicalcopypage);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(1, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 557);
            this.tabControl1.TabIndex = 61;
            // 
            // practicalcopypage
            // 
            this.practicalcopypage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.practicalcopypage.Controls.Add(this.webView21);
            this.practicalcopypage.Location = new System.Drawing.Point(4, 28);
            this.practicalcopypage.Name = "practicalcopypage";
            this.practicalcopypage.Padding = new System.Windows.Forms.Padding(3);
            this.practicalcopypage.Size = new System.Drawing.Size(1202, 525);
            this.practicalcopypage.TabIndex = 0;
            this.practicalcopypage.Text = "Practical Copy";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(3, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1196, 519);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // class12zoology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1213, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "class12zoology";
            this.Text = "class12zoology";
            this.Load += new System.EventHandler(this.class12zoology_Load);
            this.tabControl1.ResumeLayout(false);
            this.practicalcopypage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button backbtn;
        private TabControl tabControl1;
        private TabPage textbookpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TabPage modelquestionpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private TabPage practicalcopypage;
    }
}