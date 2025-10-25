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
            CmdHello = new Button();
            LblDisplay = new Label();
            SuspendLayout();
            // 
            // CmdHello
            // 
            CmdHello.Location = new Point(37, 32);
            CmdHello.Name = "CmdHello";
            CmdHello.Size = new Size(147, 79);
            CmdHello.TabIndex = 0;
            CmdHello.Text = "Hello";
            CmdHello.UseVisualStyleBackColor = true;
            CmdHello.Click += CmdHello_Click;
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = true;
            LblDisplay.Location = new Point(470, 264);
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(54, 32);
            LblDisplay.TabIndex = 1;
            LblDisplay.Text = "........";
            LblDisplay.Click += label1_Click;
            // 
            // MyFirstApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblDisplay);
            Controls.Add(CmdHello);
            Name = "MyFirstApp";
            Text = "MyFirstApp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdHello;
        private Label LblDisplay;
    }
}