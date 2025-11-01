namespace Aufgabe_1_2_5
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            CalculateButton = new Button();
            RefreshButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(568, 139);
            button1.Name = "button1";
            button1.Size = new Size(52, 46);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(511, 139);
            button2.Name = "button2";
            button2.Size = new Size(50, 46);
            button2.TabIndex = 1;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(452, 139);
            button3.Name = "button3";
            button3.Size = new Size(52, 46);
            button3.TabIndex = 2;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(394, 139);
            button4.Name = "button4";
            button4.Size = new Size(52, 46);
            button4.TabIndex = 3;
            button4.Text = "0";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(336, 139);
            button5.Name = "button5";
            button5.Size = new Size(52, 46);
            button5.TabIndex = 4;
            button5.Text = "0";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(278, 139);
            button6.Name = "button6";
            button6.Size = new Size(52, 46);
            button6.TabIndex = 5;
            button6.Text = "0";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(220, 139);
            button7.Name = "button7";
            button7.Size = new Size(52, 46);
            button7.TabIndex = 6;
            button7.Text = "0";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(162, 139);
            button8.Name = "button8";
            button8.Size = new Size(52, 46);
            button8.TabIndex = 7;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(152, 253);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(468, 46);
            CalculateButton.TabIndex = 8;
            CalculateButton.Text = "Berechne Dezimalwert";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(152, 344);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(468, 46);
            RefreshButton.TabIndex = 9;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(152, 495);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 39);
            textBox1.TabIndex = 11;
            textBox1.Text = "Wert in Dezimalzahl: ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 569);
            Controls.Add(textBox1);
            Controls.Add(RefreshButton);
            Controls.Add(CalculateButton);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Berechne Dezimalwert";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button CalculateButton;
        private Button RefreshButton;
        private TextBox textBox1;
    }
}
