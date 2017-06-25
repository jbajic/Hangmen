using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HangmanApp
{
    public partial class Highscores : Form
    {
        private OleDbConnection myConnection;
        private OleDbDataAdapter myAdapter;
        private String connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\VisualStudio Projects\HangmanApp\Hangmen.MDB";

        public Highscores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (myConnection = new OleDbConnection(connectionString))
            {
                try
                {
                    myConnection.Open();

                    using (myAdapter = new OleDbDataAdapter())
                    {

                        DataTable gamesDataset = new DataTable();
                        myAdapter.SelectCommand = new OleDbCommand(
                            "SELECT TOP 3 games.ID, games.Score, users.username" +
                            " FROM games" +
                            " INNER JOIN users ON games.userID=users.ID" +
                            " ORDER BY games.score DESC",
                            myConnection);
                        myAdapter.Fill(gamesDataset);
                        int iterations = (gamesDataset.Rows.Count > 3) ? 3 : gamesDataset.Rows.Count;
                       for (int i = 0; i < iterations; ++i)
                        {
                            DataRow row = gamesDataset.Rows[i];
                            switch(i)
                            {
                                case 0:
                                    name1.Text = row[2].ToString();
                                    score1.Text = row[1].ToString();
                                    break;
                                case 1:
                                    name2.Text = row[2].ToString();
                                    score2.Text = row[1].ToString();
                                    break;
                                case 2:
                                    name2.Text = row[2].ToString();
                                    score2.Text = row[1].ToString();
                                    break;
                            }
                        }
                        foreach (DataRow row in gamesDataset.Rows)
                        {
                            Console.WriteLine("LADIDA");
                            Console.WriteLine(row[0]);
                            Console.WriteLine(row[1]);

                        }
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

    }
}
