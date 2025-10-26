using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace Aufgabe_A1_2_4
{
    public partial class fenster : Form


    {

        int width = 844;
        int height = 677;
        public fenster()
        {
            InitializeComponent();
        }



        private void HeightUp_Click(object sender, EventArgs e)
        {
            height += 20;
            this.Size = new Size(width, height);
            this.CenterToScreen();
        }

        private void HeightDown_Click(object sender, EventArgs e)
        {
            height -= 20;
            this.Size = new Size(width, height);
            this.CenterToScreen();
        }



        private void WidhtMore_Click_1(object sender, EventArgs e)
        {
            width += 20;
            this.Size = new Size(width, height);
            this.CenterToScreen();
        }

        private void WidhtLess_Click_1(object sender, EventArgs e)
        {
            width -= 20;
            this.Size = new Size(width, height);
            this.CenterToScreen();
        }

        private void FullScreen_Click(object sender, EventArgs e)
        {
            this.Size = new Size(3200, 2000);
            this.CenterToScreen();
        }
    }

}

