using System.Xml;

namespace Aufgabe_1_2_5
{
    public partial class Form1 : Form
    {

        int MeineZahl = 0;
        int Output;


        public Form1()
        {
            InitializeComponent();

            UpdateAnzeige();


            int BinaryNumber;
            BinaryNumber = Convert.ToInt16(MeineZahl);
            Output = BinaryNumber;  


            
            
        }

        private void UpdateAnzeige() 
        {
            Convert.ToString(MeineZahl, 2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeineZahl += 1;
            button1.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeineZahl += 10;
            button2.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MeineZahl += 100;
            button3.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MeineZahl += 1000;
            button4.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MeineZahl += 10000;
            button5.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MeineZahl += 100000;
            button6.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MeineZahl += 1000000;
            button7.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MeineZahl += 10000000;
            button8.Text = Convert.ToString(1);
            textBox1.Text = "Wert in Dezimal: " + Output;
        }
    }
}
