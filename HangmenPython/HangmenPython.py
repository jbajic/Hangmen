import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Data')from System.Windows.Forms import *
from System.Data.OleDb import OleDbConnection, OleDbDataAdapter, OleDbCommand

vowels = list("aeiouy")
consonants = list("bcdfghjklmnpqrstvexz")

def importNewWordList(form, connectionString):
    form.openFileDialog1.ShowDialog()
    filename = form.openFileDialog1.FileName
    print filename
    file = open(filename, 'r')
    connection = OleDbConnection(connectionString)
    connection.Open()
    command = OleDbCommand("DELETE FROM words;", connection)
    command.ExecuteNonQuery()
    for line in file:
        number_of_consonants = sum(line.count(c) for c in consonants)
        number_of_vowels = sum(line.count(c) for c in vowels)
        score = int(number_of_consonants + number_of_vowels * 0.5)
        command = OleDbCommand("INSERT INTO words(word, score) VALUES(@word, @score);", connection)
        command.Parameters.AddWithValue("@word", line)
        command.Parameters.AddWithValue("@score", score)
        command.ExecuteNonQuery()
    connection.Close()

