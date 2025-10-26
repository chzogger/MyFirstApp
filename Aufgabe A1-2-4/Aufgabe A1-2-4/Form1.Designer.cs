namespace Aufgabe_A1_2_4
{
    partial class fenster
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
            HeightDown = new Button();
            HeightUp = new Button();
            WidhtLess = new Button();
            WidhtMore = new Button();
            FullScreen = new Button();
            SuspendLayout();
            // 
            // HeightDown
            // 
            HeightDown.Location = new Point(184, 203);
            HeightDown.Name = "HeightDown";
            HeightDown.Size = new Size(433, 46);
            HeightDown.TabIndex = 0;
            HeightDown.Text = "Fensterhöhe verkleiner";
            HeightDown.UseVisualStyleBackColor = true;
            HeightDown.Click += HeightDown_Click;
            // 
            // HeightUp
            // 
            HeightUp.Location = new Point(184, 124);
            HeightUp.Name = "HeightUp";
            HeightUp.Size = new Size(433, 46);
            HeightUp.TabIndex = 1;
            HeightUp.Text = "Fensterhöhe vergrössern";
            HeightUp.UseVisualStyleBackColor = true;
            HeightUp.Click += HeightUp_Click;
            // 
            // WidhtLess
            // 
            WidhtLess.Location = new Point(184, 362);
            WidhtLess.Name = "WidhtLess";
            WidhtLess.Size = new Size(433, 46);
            WidhtLess.TabIndex = 2;
            WidhtLess.Text = "Fensterbreite verkleinern";
            WidhtLess.UseVisualStyleBackColor = true;
            WidhtLess.Click += WidhtLess_Click_1;
            // 
            // WidhtMore
            // 
            WidhtMore.Location = new Point(184, 284);
            WidhtMore.Name = "WidhtMore";
            WidhtMore.Size = new Size(433, 46);
            WidhtMore.TabIndex = 3;
            WidhtMore.Text = "Fensterbreite erweitern";
            WidhtMore.UseVisualStyleBackColor = true;
            WidhtMore.Click += WidhtMore_Click_1;
            // 
            // FullScreen
            // 
            FullScreen.Location = new Point(300, 444);
            FullScreen.Name = "FullScreen";
            FullScreen.Size = new Size(194, 53);
            FullScreen.TabIndex = 4;
            FullScreen.Text = "Überraschung";
            FullScreen.UseVisualStyleBackColor = true;
            FullScreen.Click += FullScreen_Click;
            // 
            // fenster
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 606);
            Controls.Add(FullScreen);
            Controls.Add(WidhtMore);
            Controls.Add(WidhtLess);
            Controls.Add(HeightUp);
            Controls.Add(HeightDown);
            Name = "fenster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aufgabe A1-2-4";
            ResumeLayout(false);
        }

        #endregion

        private Button HeightDown;
        private Button HeightUp;
        private Button WidhtLess;
        private Button WidhtMore;
        private Button FullScreen;
    }
}
