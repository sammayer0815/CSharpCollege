using System.Security.Cryptography.X509Certificates;

namespace Opdracht_2
{
    public partial class Form1 : Form
    {

        private string currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = "X";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton.Text == "")
            {
                clickedButton.Text = currentPlayer;
            }
            else { return; }

            // Checks Horizontal values
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }

            //Checks Vertical values 
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }

            // Checks diagonal values
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }
            else if (button3.Text == button5.Text && button5.Text == button8.Text && button3.Text != "")
            {
                label1.Text = $"Player {currentPlayer} has won.";
                return;
            }


            switch (currentPlayer)
            {
                case "X":
                    currentPlayer = "O";
                    break;
                case "O":
                    currentPlayer = "X";
                    break;
            }

            label1.Text = $"Current player: {currentPlayer}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
