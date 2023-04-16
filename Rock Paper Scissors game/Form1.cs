using System.Security.Cryptography.X509Certificates;

namespace Rock_Paper_Scissors_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            

        }

        //set this to file location to keep track of scores




        


        





        int plyrscore = 0;
        int compscore = 0;

        //RADIO BUTTONS


        private void rockbutton_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void paperbutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void scibutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lizardbutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void spockbutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        //END OF RADIO BUTTONS



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }



        //READY BUTTON
        private void readybtn_Click(object sender, EventArgs e)
        {




            Random random = new Random();
            int num = random.Next(1, 6);




        

                if (rockbutton.Checked)
                {
                    if (num == 1)
                    {
                        textbox.Text = "Rock hits Rock \nDraw!";
                    }

                    if (num == 2)
                    {
                        textbox.Text = "Paper covers Rock \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 3)
                    {
                        textbox.Text = "Rock crushes Scissors \nPlayer Wins!";
                        plyrscore++;
                    }
                    if (num == 4)
                    {
                        textbox.Text = "Rock crushes Lizard \nPlayer Wins!";
                        plyrscore++;
                    }
                    if (num == 5)
                    {
                        textbox.Text = "Spock vaporizes Rock \nComputer Wins!";
                        compscore++;
                    }



                }
                if (paperbutton.Checked)
                {
                    if (num == 1)
                    {
                        textbox.Text = "Paper covers Rock \nPlayer Wins!";
                        plyrscore++;
                    }

                    if (num == 2)
                    {
                        textbox.Text = "Paper covers Paper \nDraw!";
                    }

                    if (num == 3)
                    {
                        textbox.Text = "Scissors cuts Paper \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 4)
                    {
                        textbox.Text = "Lizard eats Paper \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 5)
                    {
                        textbox.Text = "Paper disproves Spock \nPlayer Wins!";
                        plyrscore++;
                    }



                }

                if (scibutton.Checked)
                {
                    if (num == 1)
                    {
                        textbox.Text = "Rock crushes Scissors \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 2)
                    {
                        textbox.Text = "Scissors cuts Paper \nPlayer Wins!";
                        plyrscore++;
                    }

                    if (num == 3)
                    {
                        textbox.Text = "Scissors Cuts Scissors \nDraw!";
                    }

                    if (num == 4)
                    {
                        textbox.Text = "Scissors decapitates Lizard \nPlayer Wins";
                        plyrscore++;
                    }

                    if (num == 5)
                    {
                        textbox.Text = "Spock smashes Scissors \nComputer Wins!";
                        compscore++;
                    }
                }


                if (lizardbutton.Checked)
                {
                    if (num == 1)
                    {
                        textbox.Text = "Rock crushes Lizard \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 2)
                    {
                        textbox.Text = "Lizard eats Paper \nPlayer Wins!";
                        plyrscore++;
                    }

                    if (num == 3)
                    {
                        textbox.Text = "Scissors decapitates Lizard \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 4)
                    {
                        textbox.Text = "Lizard eats Lizard \nDraw!";
                    }

                    if (num == 5)
                    {
                        textbox.Text = "Lizard poisons Spock \nPlayer Wins!";
                        plyrscore++;
                    }

                }

                if (spockbutton.Checked)
                {
                    if (num == 1)
                    {
                        textbox.Text = "Spock vaporizes Rock \nPlayer Wins!";
                        plyrscore++;

                    }

                    if (num == 2)
                    {
                        textbox.Text = "Paper disproves Spock \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 3)
                    {
                        textbox.Text = "Spock smashes Scissors \nPlayer Wins!";
                        plyrscore++;
                    }

                    if (num == 4)
                    {
                        textbox.Text = "Lizard poisons Spock \nComputer Wins!";
                        compscore++;
                    }

                    if (num == 5)
                    {
                        textbox.Text = "Spock disproves Spock \nDraw!";
                    }






                }

            

            if (compscore == 3)
            {
                winbox.Text = "Computer has won!";
                compscore = 0;
                plyrscore = 0;
                
                
            }

            else if (plyrscore == 3)
            {
                winbox.Text = "Player has won!";
                plyrscore = 0;
                compscore = 0;
               
            }

            StreamWriter writer = new StreamWriter("score.txt");

            writer.WriteLine("Players score is: " + plyrscore);

            writer.WriteLine("Computers score is: " + compscore);

            writer.Close();

            scorestxt.Text = "Scores: \nPlayers Score is: " + plyrscore + "\nComputers Score is: " + compscore;

            
        }








        private void scorestxt_TextChanged(object sender, EventArgs e)
        {

        }





    }



}