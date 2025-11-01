using System.Xml;

namespace Aufgabe_1_2_5
{
    public partial class Form1 : Form
    {


        int MeineZahl = 0;
        string BinaryNumber;

        public Form1()
        {
            InitializeComponent();
            


        }


        private void Zahlausgeben()
            
        {

            if (MeineZahl == 11111111)
            { 
            
            }

            
            BinaryNumber = Convert.ToString(Convert.ToInt32(MeineZahl.ToString(), 2));
            textBox1.Text = "Wert in Dezimalzahl: " + BinaryNumber;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            MeineZahl += 1;
            Zahlausgeben();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "1";
            MeineZahl += 10;
            Zahlausgeben();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "1";
            MeineZahl += 100;
            Zahlausgeben();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "1";
            MeineZahl += 1000;
            Zahlausgeben();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "1";
            MeineZahl += 10000;
            Zahlausgeben();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "1";
            MeineZahl += 100000;
            Zahlausgeben();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "1";
            MeineZahl += 1000000;
            Zahlausgeben();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "1";
            MeineZahl += 10000000;
            Zahlausgeben();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Dezimalzahl: ";
            MeineZahl = 0;
            button1.Text = "1";
            button2.Text = "1";
            button3.Text = "1";
            button4.Text = "1";
            button5.Text = "1";
            button6.Text = "1";
            button7.Text = "1";
            button8.Text = "1";
          
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Zahlausgeben();
        }
    }
}
