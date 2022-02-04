using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp3
{
    public partial class Game : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        WindowsMediaPlayer player = new WindowsMediaPlayer();


        public Game()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

            player.URL = "justfriends.mp3";

        }

        private void Game_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {



            switch (qnum)
            {

                case 1:
                    pictureBox2.Image = Properties.Resources.Sky;

                    lblQuestion.Text = "What is the colour of the Sky?";

                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Purple";
                    button4.Text = "Red";

                    correctAnswer = 1;

                    break;
                case 2:

                    pictureBox2.Image = Properties.Resources.Aatrox;

                    lblQuestion.Text = "What is the name of this Character?";

                    button1.Text = "Aatrox";
                    button2.Text = "Quinn";
                    button3.Text = "Maokai";
                    button4.Text = "Victor";

                    correctAnswer = 1;

                    break;

                case 3:

                    pictureBox2.Image = Properties.Resources.LoL;

                    lblQuestion.Text = "Which lane in League of Legends using hosts mages?";

                    button1.Text = "Top";
                    button2.Text = "Jungle";
                    button3.Text = "Mid";
                    button4.Text = "Bot";

                    correctAnswer = 3;

                    break;

                case 4:

                    pictureBox2.Image = Properties.Resources.Pilots;

                    lblQuestion.Text = "What are the name of the people who pilot the Titans in TitanFall?";

                    button1.Text = "Grunts";
                    button2.Text = "Sentinels";
                    button3.Text = "Spyders";
                    button4.Text = "Pilots";

                    correctAnswer = 4;

                    break;

                case 5:

                    pictureBox2.Image = Properties.Resources.Valorant;

                    lblQuestion.Text = "What is the main goal in Valorant";

                    button1.Text = "Kill the Enemies";
                    button2.Text = "Plant the Spike";
                    button3.Text = "First to win 13 Rounds";
                    button4.Text = "Sit in Spawn";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox2.Image = Properties.Resources.Enlisted;

                    lblQuestion.Text = "What genre of game is Enlisted?";

                    button1.Text = "RPG-MMO";
                    button2.Text = "RTS";
                    button3.Text = "RPG";
                    button4.Text = "FPS";

                    correctAnswer = 1;

                    break;

                case 7:

                    pictureBox2.Image = Properties.Resources.Valorant;

                    lblQuestion.Text = "What game is Valorant most similar to?";

                    button1.Text = "Counter Strike Go";
                    button2.Text = "Call of Duty";
                    button3.Text = "Battlefield";
                    button4.Text = "Half Life 3";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox2.Image = Properties.Resources.Kaisa;

                    lblQuestion.Text = "What is the name of this character?";

                    button1.Text = "Gwen";
                    button2.Text = "Kai'sa";
                    button3.Text = "Sivir";
                    button4.Text = "Vayne";

                    correctAnswer = 2;

                    break;




            }




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            player.controls.stop();
        }
    }
}