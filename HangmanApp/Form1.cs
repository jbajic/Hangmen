using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using HangmanApp.Models;
using System.Text;

namespace HangmanApp
{
    public partial class Form1 : Form
    {
        private OleDbConnection myConnection;
        private OleDbDataAdapter myAdapter;
        private String connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\VisualStudio Projects\HangmanApp\Hangmen.MDB";
        private Graphics graphics;
        private Game currentGame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startGameOrGetNewWord(true);
        }

        private void startGameOrGetNewWord(bool startGame)
        {
            lbUsedLetters.Text = "";
            if (startGame)
            {
                currentGame = new Game(panel1);
                using (myConnection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        myConnection.Open();

                        using (myAdapter = new OleDbDataAdapter())
                        {

                            DataTable wordDataset = new DataTable();
                            myAdapter.SelectCommand = new OleDbCommand("SELECT * FROM words", myConnection);
                            myAdapter.Fill(wordDataset);
                            foreach (DataRow row in wordDataset.Rows)
                            {
                                Word wordModel = new Word(
                                    Convert.ToInt16(row[0]),
                                    row[1].ToString(),
                                    Convert.ToInt16(row[2])
                                );
                                Console.WriteLine(wordModel.name);
                                currentGame.wordList.Add(wordModel);
                            }
                            currentGame.getNewWord();
                            labelWord.Text = currentGame.currentWord.word;
                            tbPoints.Text = Convert.ToString(currentGame.points);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        myConnection.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine("AJMOOOOO");
                this.currentGame.wordSolved();
                tbPoints.Text = Convert.ToString(currentGame.points);
                if (currentGame.getNewWord())
                {
                    MessageBox.Show("You have finished the game", "Bravoo", MessageBoxButtons.OK);
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "Congratulations!", "Default", -1);
                    Console.WriteLine(input);
                    using (myConnection = new OleDbConnection(connectionString))
                    {
                        try
                        {
                            myConnection.Open();

                            int userID = 0;
                            //check if user exists
                            OleDbCommand checkForUser = new OleDbCommand("SELECT * FROM users WHERE username = @username", myConnection);
                            checkForUser.Parameters.Add("@username", OleDbType.VarChar);
                            checkForUser.Parameters["@username"].Value = input;
                            var reader = checkForUser.ExecuteReader();

                            //int count = (int) checkForUser.ExecuteScalar();
                            if(!reader.Read())
                            {
                                OleDbCommand insertUser = new OleDbCommand("INSERT INTO users(username) VALUES (@username)", myConnection);
                                OleDbCommand getLastID = new OleDbCommand("Select @@Identity", myConnection);
                                insertUser.Parameters.AddWithValue("@username", input);
                                insertUser.ExecuteNonQuery();

                                userID = (int)getLastID.ExecuteScalar();
                            }
                            else
                            {
                                userID = (int) reader["ID"];
                            }

                            //insert game
                            OleDbCommand insertGame = new OleDbCommand("INSERT INTO games(score, userID) VALUES (@score, @userID)", myConnection);
                            insertGame.Parameters.AddWithValue("@score", currentGame.points);
                            insertGame.Parameters.AddWithValue("@userID", userID);
                            insertGame.ExecuteNonQuery();
                            Console.WriteLine(userID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                        }
                        finally
                        {
                            myConnection.Close();
                            startGameOrGetNewWord(true);
                        }
                    }
                }
                else
                {
                    labelWord.Text = currentGame.currentWord.word;
                }
            }
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            if(tbLetter.Text.Length != 0)
            {
                Char givenLetter = tbLetter.Text[0];
                currentGame.usedLetters.Add(givenLetter);

                Boolean match = false;
                lbUsedLetters.Text += givenLetter;
                match = currentGame.checkWord(givenLetter);
                
                if (currentGame.currentWord.word.Equals(currentGame.currentWord.name))
                {
                    Console.WriteLine("FINISHED word");
                    this.startGameOrGetNewWord(false);
                }
                else if (match)
                {
                    Console.WriteLine("MATCH JE");
                    //currentGame.currentWord.word = newWord.ToString();
                    labelWord.Text = currentGame.currentWord.word;
                }
                else
                {
                    Console.WriteLine("NIJE MATCH");
                    if(currentGame.missedALetter())
                    {
                        //startGame
                        MessageBox.Show("You were hanged... Click ok to start a new game!", "GAME OVER", MessageBoxButtons.OK);
                        this.startGameOrGetNewWord(true);
                    }
                }
                tbLetter.Text = "";
            }
            
        }

        private void btWord_Click(object sender, EventArgs e)
        {
            if (tbWord.Text.Length != 0)
            {
                String givenWord = tbWord.Text;

                if(givenWord == currentGame.currentWord.name)
                {
                    tbWord.Text = "";
                    this.startGameOrGetNewWord(false);
                }
                else if (currentGame.missedALetter())
                {
                    tbWord.Text = "";
                    if (currentGame.missedALetter())
                    {
                        //startGame
                        MessageBox.Show("You were hanged... Click ok to start new game!", "GAME OVER", MessageBoxButtons.OK);
                        this.startGameOrGetNewWord(true);
                    }
                }
            }
        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscores highscoreForm = new Highscores();

            highscoreForm.Show();
        }

        private void importWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
