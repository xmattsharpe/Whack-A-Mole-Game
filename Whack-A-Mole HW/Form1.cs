using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 
using System.Windows.Forms;
using System.Xml.Schema;

namespace Whack_A_Mole_HW
{
    public partial class Form1 : Form
    {
        int score = 0;
        // user score
        private Stopwatch totalTime = new Stopwatch();
        public Random Mole_Time = new Random(); // Random Num Generator to move the Mole pitcure around.
        PictureBox mole = new PictureBox();

        int clickCounter = 0; // holds the amount of attempts the user makes a click to strike the mole

        double AVG =0; // holds the average time (total time taken / clicks)

        public Form1()
        {
      
            InitializeComponent();
          
        }

    
        private void WinLose()
        {

            // storing the total amount of seconds the timer runs for while user plays
            double timeTaken = totalTime.Elapsed.TotalSeconds;

            AVG = timeTaken / clickCounter;

            // checking to see if there is a win or loss, score of over 20 is a win, less than -2 is a loss.
            if (score >= 10)
            {
                WinLbl.Visible = true;
                WinLbl.Text = "Congrats, you wacked 10 moles, you have won!";

                // calculating the average time for user to press a mole and diaplying it.
                
                Button_AverageTime.Text = "Average time to ATTEMPT to click a mole: " + AVG.ToString() + " seconds";

                // prompting user on directions of how to play again if they'd like.
                User_Directions.Visible = true;
                User_Directions.Text = "To play again, please press quit, and then Start";

                // mole picture is no longer visible until user starts a new round.
                Mole.Visible = false;
                // score is no longer visible until game is retarted 
                Button_Score.Visible = false; 
                

            }
            else if (score < -2)
            {
                // mole picture is no longer visible until user starts a new round.
                Mole.Visible = false;

                WinLbl.Visible = true;
                WinLbl.Text = "Sorry, You lost! Your score hit -2! ";
             Button_AverageTime.Text = "Average time to ATTEMPT to click a mole: " + AVG.ToString() + " seconds";

                // prompting user on directions of how to play again if they'd like.
                User_Directions.Visible = true;
                User_Directions.Text = "To play again, please press quit, and then Start";
                // score is no longer visible until game is retarted 
                Button_Score.Visible = false;

            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            totalTime.Start();

          

            Mole.Visible = true;
           
            // BEGIN STOPWATCH
            Button_Start.Enabled = false;
            WinLbl.Visible = false;
            // disables the start button after pressed 

            // only changing the cursor if the user is hovered over the mole picture
            Cursor c = new Cursor("C:\\Users\\matth\\Downloads\\62953-hammer-icon.cur");
            Mole.Cursor = c;

            Button_Score.Visible = true;
            // score is now visible to user again
           

         

        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            totalTime.Stop();
            // STOP STOPWATCH
            Button_Start.Enabled = true;
            Button_Stop.Enabled = false;
            // Enable the start button if the stop button is pressed and disable the stop button

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (Button_Start.Enabled == false)
            {
                Mole.Left = Mole_Time.Next(100, 385);
                Mole.Top = Mole_Time.Next(50, 200);
                  
                // These height and width values are approximations to make my mole appear on the screen in only places that visible and somewhat center.
            }
        }

        private void Button_Quit_Click(object sender, EventArgs e)
        {

            totalTime.Stop();
            totalTime.Reset();

            // if quit is pressed, enable both the start and top buttons
            Button_Start.Enabled = true;
            Button_Stop.Enabled = true;

            // disable the picture until start is pressed again
            Mole.Visible = false;

            // resetting the score back to 0 for a new round.
            score = 0;
            Button_Score.Text = "Score: " + score.ToString();

            // resetting the average back to zero for a new round.
            AVG = 0;
            Button_AverageTime.Text = null;

            // hiding these button until the next round is over.
            WinLbl.Visible = false;
            User_Directions.Visible = false;




        }

        private void Mole_Click(object sender, EventArgs e)
        {
            // if user clicks on the Mole, add a point to the score
            score++;
            clickCounter++;
            Button_Score.Text = "Score: " + score.ToString();
            WinLose();

            
        }

      

        private void Form1_Click(object sender, EventArgs e)
        {
            // this allows me to subtract points if the user clicks anywhere else on the form that isnt the mole
            score--;
            clickCounter++;
            Button_Score.Text = "Score: " + score.ToString();
           
            
            WinLose();

            // I have called this method in two events because whether or not the user clicks on the mole or misses it, the method will be called form either event to display a win or loss.
        }

       
    }
}
