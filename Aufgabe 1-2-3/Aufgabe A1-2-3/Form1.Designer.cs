namespace Aufgabe_A1_2_3
{
    partial class Form1
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
            HomeButton = new Button();
            DownButton = new Button();
            RightButton = new Button();
            UpButton = new Button();
            LeftButton = new Button();
            Field1Button = new Button();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(325, 116);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(150, 46);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(325, 168);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(150, 46);
            DownButton.TabIndex = 1;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click_1;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(481, 116);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(150, 46);
            RightButton.TabIndex = 2;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // UpButton
            // 
            UpButton.Location = new Point(325, 64);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(150, 46);
            UpButton.TabIndex = 3;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(169, 116);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(150, 46);
            LeftButton.TabIndex = 4;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click_1;
            // 
            // Field1Button
            // 
            Field1Button.BackColor = Color.RoyalBlue;
            Field1Button.Location = new Point(159, 299);
            Field1Button.Name = "Field1Button";
            Field1Button.Size = new Size(52, 46);
            Field1Button.TabIndex = 5;
            Field1Button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 646);
            Controls.Add(Field1Button);
            Controls.Add(LeftButton);
            Controls.Add(UpButton);
            Controls.Add(RightButton);
            Controls.Add(DownButton);
            Controls.Add(HomeButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button DownButton;
        private Button RightButton;
        private Button UpButton;
        private Button LeftButton;
        private Button Field1Button;
    }
}
