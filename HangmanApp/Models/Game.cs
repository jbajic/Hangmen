using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HangmanApp.Models
{
    class Game
    {
        public List<Word> wordList = new List<Word>();
        private HangmenObj hangmanObject;
        public int points { get; set; }
        private System.Windows.Forms.Panel panel;
        public List<Char> usedLetters = new List<Char>();
        public Word currentWord;

        public Game(System.Windows.Forms.Panel panel)
        {
            this.points = 0;
            hangmanObject = new HangmenObj(panel);
            this.hangmanObject.restartHangman();
            this.panel = panel;
        }

        public void wordSolved()
        {
            this.points += currentWord.score;
            this.hangmanObject.restartHangman();
            usedLetters.Clear();
        }

        public bool missedALetter()
        {
            return hangmanObject.drawHangmen();
        }

        public bool checkWord(Char givenLetter)
        {
            Boolean match = false;
            StringBuilder newWord = new StringBuilder();
            for (int i = 0; i < this.currentWord.name.Length; ++i)
            {
                if (char.IsLetter(this.currentWord.name[i]))
                {
                    if (this.usedLetters.Contains(this.currentWord.name[i]))
                    {
                        if (this.currentWord.name[i] == givenLetter)
                        {
                            match = true;
                        }
                        newWord.Append(this.currentWord.name[i]);
                    }
                    else
                    {
                        newWord.Append("_ ");
                    }
                }
                else
                {
                    newWord.Append(this.currentWord.name[i]);
                }
            }
            this.currentWord.word = newWord.ToString();
            return match;
        }

        public bool getNewWord()
        {
            Console.WriteLine("COUNT");
            Console.WriteLine((wordList.Count));
            Random rand = new Random();
            if(wordList.Count > 0)
            {
                this.currentWord = wordList[rand.Next(wordList.Count)];
                wordList.Remove(currentWord);
                Console.WriteLine("CURRENT WORD");
                Console.WriteLine(currentWord.name);
                return false;
            }
            else
            {
                return true;
            }
            
        }

    }
}
