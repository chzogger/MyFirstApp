using System;
using System.Reflection;

namespace Aufgabe_A1_2_3
{
    public partial class Form1 : Form
    {


        Point meinePosition = new Point(374, 387);

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Field1Button.Location = new Point(374, 387);
            meinePosition = Field1Button.Location;
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            meinePosition.Y -= 10;
            Field1Button.Location = meinePosition;

        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            meinePosition.X += 10;
            Field1Button.Location = meinePosition;
        }

      
               

        private void DownButton_Click_1(object sender, EventArgs e)
        {
            meinePosition.Y += 10;
            Field1Button.Location = meinePosition;
        }

        private void LeftButton_Click_1(object sender, EventArgs e)
        {
            meinePosition.X -= 10;
            Field1Button.Location = meinePosition;
        }
    }
}
