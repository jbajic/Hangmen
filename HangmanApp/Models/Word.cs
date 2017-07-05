using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HangmanApp.Models
{
    class Word : IEquatable<Word>
    {
        public Word(int id, String name, int score)
        {
            this.id = id;
            this.name = name.Trim().ToUpper();
            this.score = score;
            Regex rgx = new Regex("[A-Z]");
            this.word = rgx.Replace(this.name, "_ ");
            //this.word = new StringBuilder().Insert(0, "_ ", name.Length).ToString();
        }

        public int id { get; private set; }
        public String name { get; set; }
        public int score { get; set; }
        public String word { get; set; }

        public bool Equals(Word other)
        {
            return this.id == other.id;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.id);
        }
    }
}
