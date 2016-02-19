using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Classes
{
    public class Hangman
    {
        private string word;
        private StringBuilder obfuscated = new StringBuilder();        
        private int lives = 6;
        private int guessCount = 0;

        public Hangman(string word)
        {
            this.word = word;
            obfuscate(word);            
        }

        public string Guess(char letter)
        {
            if (lives == 0)
                return string.Format("You got hung! The word was {0}.", word);
            else if (guessCount == word.Length)
                return "The game has ended.";
            else
                checkLetter(letter);

            if (guessCount == word.Length)
                return string.Format("You found the word! ({0})", word);
            else
                return obfuscated.ToString();
            
        }

        private void checkLetter(char c)
        {
             var index = word.IndexOf(c);
             if (index != -1)
             {
               fillInBlank(c, index);
             }
            else
            {
                appendMiss(c);
            }
             
        }
        private void appendMiss(char c)
        {
            //if (lives == 0)
            //    return;
            if (obfuscated.ToString().IndexOf('#')==-1)
            {
                obfuscated.Append(" # " + c);
            }
            else
            {
                obfuscated.Append(c);
            }
            lives--;
        }
        private void fillInBlank(char c, int index)
        {
            obfuscated.Remove(index + index, 1);
           obfuscated.Insert(index+index, c);
            guessCount++;
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
