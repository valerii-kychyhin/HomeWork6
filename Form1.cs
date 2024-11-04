using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            label1.Text = "Try to beat me in Rock, Paper, Scissors!";
            label2.Text = ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }

        private void PlayGame(string userChoice)
        {
            string computerChoice = GetComputerChoice();

            string result = DetermineWinner(userChoice, computerChoice);

           
            label2.Text = $"You picked: {userChoice}\nComputer picked: {computerChoice}\nResult: {result}";
        }

        private string GetComputerChoice()
        {
            Random random = new Random();
            int choice = random.Next(1, 4); 
            if (choice == 1) return "Rock";
            if (choice == 2) return "Paper";
            return "Scissors";
        }

        private string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "Draw!";
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                     (userChoice == "Scissors" && computerChoice == "Paper") ||
                     (userChoice == "Paper" && computerChoice == "Rock"))
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }
    }
}
