﻿namespace WinFormsApp1
{
    partial class MyFirstApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdButtonYellow = new Button();
            CmdButtonBlue = new Button();
            CmdButtonRed = new Button();
            CmdButtonGreen = new Button();
            feld1 = new Label();
            feld2 = new Label();
            feld3 = new Label();
            feld4 = new Label();
            SuspendLayout();
            // 
            // CmdButtonYellow
            // 
            CmdButtonYellow.Location = new Point(37, 32);
            CmdButtonYellow.Name = "CmdButtonYellow";
            CmdButtonYellow.Size = new Size(147, 79);
            CmdButtonYellow.TabIndex = 0;
            CmdButtonYellow.Text = "Gelb";
            CmdButtonYellow.UseVisualStyleBackColor = true;
            CmdButtonYellow.Click += CmdHello_Click;
            // 
            // CmdButtonBlue
            // 
            CmdButtonBlue.Location = new Point(37, 361);
            CmdButtonBlue.Name = "CmdButtonBlue";
            CmdButtonBlue.Size = new Size(147, 79);
            CmdButtonBlue.TabIndex = 2;
            CmdButtonBlue.Text = "Blau";
            CmdButtonBlue.UseVisualStyleBackColor = true;
            CmdButtonBlue.Click += CmdButtonBlue_Click;
            // 
            // CmdButtonRed
            // 
            CmdButtonRed.Location = new Point(37, 137);
            CmdButtonRed.Name = "CmdButtonRed";
            CmdButtonRed.Size = new Size(147, 79);
            CmdButtonRed.TabIndex = 3;
            CmdButtonRed.Text = "Rot";
            CmdButtonRed.UseVisualStyleBackColor = true;
            CmdButtonRed.Click += CmdButtonRed_Click;
            // 
            // CmdButtonGreen
            // 
            CmdButtonGreen.Location = new Point(37, 241);
            CmdButtonGreen.Name = "CmdButtonGreen";
            CmdButtonGreen.Size = new Size(147, 79);
            CmdButtonGreen.TabIndex = 4;
            CmdButtonGreen.Text = "Grün";
            CmdButtonGreen.UseVisualStyleBackColor = true;
            CmdButtonGreen.Click += CmdButtonGreen_Click;
            // 
            // feld1
            // 
            feld1.AutoSize = true;
            feld1.Location = new Point(266, 79);
            feld1.Name = "feld1";
            feld1.Size = new Size(0, 32);
            feld1.TabIndex = 5;
            feld1.Click += label1_Click_1;
            // 
            // feld2
            // 
            feld2.AutoSize = true;
            feld2.Location = new Point(266, 184);
            feld2.Name = "feld2";
            feld2.Size = new Size(0, 32);
            feld2.TabIndex = 6;
            feld2.Click += feld2_Click;
            // 
            // feld3
            // 
            feld3.AutoSize = true;
            feld3.Location = new Point(266, 288);
            feld3.Name = "feld3";
            feld3.Size = new Size(0, 32);
            feld3.TabIndex = 7;
            // 
            // feld4
            // 
            feld4.AutoSize = true;
            feld4.Location = new Point(266, 408);
            feld4.Name = "feld4";
            feld4.Size = new Size(0, 32);
            feld4.TabIndex = 8;
            // 
            // MyFirstApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 595);
            Controls.Add(feld4);
            Controls.Add(feld3);
            Controls.Add(feld2);
            Controls.Add(feld1);
            Controls.Add(CmdButtonGreen);
            Controls.Add(CmdButtonRed);
            Controls.Add(CmdButtonBlue);
            Controls.Add(CmdButtonYellow);
            Name = "MyFirstApp";
            Text = "MyFirstApp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButtonYellow;
        private Button CmdButtonBlue;
        private Button CmdButtonRed;
        private Button CmdButtonGreen;
        private Label feld1;
        private Label feld2;
        private Label feld3;
        private Label feld4;
    }
}