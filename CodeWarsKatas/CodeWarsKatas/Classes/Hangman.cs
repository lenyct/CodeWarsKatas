using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsKatas.Classes
{
    public class Hangman
    {
        private string word;
        private StringBuilder obfuscated = new StringBuilder();
        private StringBuilder misses = new StringBuilder();     
        private int lives;
        private bool gameEnded;

        public Hangman(string word)
        {
            this.word = word;
            obfuscate(word);
            gameEnded = false;
            lives = 6;     
        }

        public string Guess(char letter)
        {
            if (gameEnded)
                return "The game has ended.";

            if(!misses.ToString().Contains(letter) )
                checkLetter(letter);

            if (!obfuscated.ToString().Contains('_'))
            {
                gameEnded = true;
                return string.Format("You found the word! ({0})", word);
            }

            if (lives < 0)
                return string.Format("You got hung! The word was {0}.", word);

            else
                return obfuscated.ToString()+misses.ToString();
            
        }

        private void checkLetter(char c)
        {
            
            List<int> index = recursiveLetterCheck(c);            

            if (index.Any())
            {
                fillInBlank(c, index);
            }
            else
            {
                appendMiss(c);
            }

        }

        private List<int> recursiveLetterCheck(char c)
        {
            return word.Select((vals, i) => new { Values = vals, Index = i })
                .Where(x => word.IndexOf(c, x.Index) != -1)
                .Select(x => word.IndexOf(c, x.Index))
                .ToList();
        }

        private void appendMiss(char c)
        {
            if (misses.Length == 0)
                misses.Append(" # " + c);
            else
                misses.Append(c);
            lives--;
        }
        private void fillInBlank(char c, List<int> index)
        {
           foreach(var i in index)
            {
                obfuscated.Remove(i + i, 1);
                obfuscated.Insert(i + i, c);                
            }            
        }

        private void obfuscate(string word)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in word)
                sb.Append("_ ");
            var t = sb.ToString().TrimEnd();
            obfuscated.Append(t); 
        }
    }
}
