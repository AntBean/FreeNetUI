﻿namespace FreeTextEditor
{
    partial class LinkDlg
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
            this.hyperdest = new System.Windows.Forms.TextBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "网址:";
            // 
            // hyperdest
            // 
            this.hyperdest.Location = new System.Drawing.Point(14, 44);
            this.hyperdest.Name = "hyperdest";
            this.hyperdest.Size = new System.Drawing.Size(360, 21);
            this.hyperdest.TabIndex = 2;
            this.hyperdest.Text = "http://";
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(75, 85);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 23);
            this.insertbtn.TabIndex = 5;
            this.insertbtn.Text = "插入";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(241, 85);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "取消";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // LinkDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 130);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.hyperdest);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LinkDlg";
            this.Text = "插入超链接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hyperdest;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}