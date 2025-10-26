using System.Diagnostics.Metrics;

namespace Aufgabe_1_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        int meineZahl = 1;
        
               



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ".";
            meineZahl += 1;
            counter.Text = meineZahl.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "..";
            meineZahl += 2;
            counter.Text = meineZahl.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "...";
            meineZahl += 3;
            counter.Text = meineZahl.ToString();
        }

        private void ResetButtom_Click(object sender, EventArgs e)
        {
            label1.Text = ".";
            meineZahl = 1;
            counter.Text = meineZahl.ToString();
        }
    }
}
