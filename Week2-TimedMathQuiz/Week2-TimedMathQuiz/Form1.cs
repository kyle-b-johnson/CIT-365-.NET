using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Week2_TimedMathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer
        // to generate random numbers
        Random randomizer = new Random();

        // Variable for the amount of time left in quiz 
        int timeLeft;

        // Variables for addition problem
        int addend1, addend2;

        // Variables for subtraction problem
        int minuend, subtrahend;

        // Variables for multiplication problem
        int multiplicand, multiplier;

        // Variables for division problem
        int dividend, divisor;

        public Form1()
        {
            InitializeComponent();
            SetFormDate();
        }

        /// <summary>
        /// Starts the quiz and initializes the values in the quiz
        /// and starts the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            timeLabel.BackColor = Color.Empty;

            // Generate numbers for the addition problem of the quiz
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Insert the randomized numbers into the quiz form
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            
            // Initialize the numeric control to 0 at the start of the quiz
            sum.Value = 0;

            // Fill in the subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in multiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in multiplication problem
            divisor = randomizer.Next(2, 11);
            int tempQuotient = randomizer.Next(2, 11);
            dividend = divisor * tempQuotient ;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            product.Value = 0;


            // Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        public void SetFormDate()
        {
            DateTime today = DateTime.Now;
            String[] monthName = {"January", "February", "March", "April"
                    , "May", "June", "July", "August", "September", "October"
                    , "November", "December" };
            dateLabel.Text = today.Day.ToString() + " "
                + monthName[today.Month-1] + " "
                + today.Year.ToString();
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
                SystemSounds.Hand.Play();
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if(minuend - subtrahend == difference.Value)
                SystemSounds.Hand.Play();
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if(multiplicand * multiplier == product.Value)
                SystemSounds.Hand.Play();
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if(dividend / divisor == quotient.Value)
                SystemSounds.Hand.Play();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Checks the answer and congratulates the user 
                // if answer is correct
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", 
                    "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 6)
            {
                // Timer ticks down in one second increments
                // while the answer is false.
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else if (timeLeft > 0)
            {
                // Change color of timer to red when 5 or less seconds remain
                timeLabel.BackColor = Color.Red;

                // Timer ticks down in one second increments
                // while the answer is false.
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // Stop timer if user does not complete quiz in time,
                // tell user time is up, and show correct answers
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor; 
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

       
    }
}
