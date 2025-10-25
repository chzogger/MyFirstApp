namespace WinFormsApp1
{
    public partial class MyFirstApp : Form
    {
        public MyFirstApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmdHello_Click(object sender, EventArgs e)
        {
            feld1.Text = "Gelbe Hintergrundfarbe";
            feld1.BackColor = Color.Yellow;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void feld2_Click(object sender, EventArgs e)
        {

        }

        private void CmdButtonRed_Click(object sender, EventArgs e)
        {
            feld2.Text = "Rote Hintergrundfarve";
            feld2.BackColor = Color.Red;
        }

        private void CmdButtonGreen_Click(object sender, EventArgs e)
        {
            feld3.Text = "Grüner Hintergrund";
            feld3.BackColor = Color.Green;

        }

        private void CmdButtonBlue_Click(object sender, EventArgs e)
        {
            feld4.Text = "Blauer Hintergrund";
            feld4.BackColor = Color.Blue;
        }
    }
}
