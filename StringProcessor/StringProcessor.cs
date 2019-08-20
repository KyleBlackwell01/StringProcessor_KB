using System;
using System.Linq;

namespace StringProcessor
{
    public class Processor
    {
        /// <summary>
        /// Returns number of char found in word.  Case-insensitive.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int CountChar(string word, char c) {
            return word.Count(x => char.ToUpperInvariant(x) == char.ToUpperInvariant(c));

            //throw new NotImplementedException();
        }

        /// <summary>
        /// Returns word in reverse.  Case sensitive.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string Reverse(string word) {
            char[] wArray = word.ToCharArray();
            Array.Reverse(wArray);
            return new string(wArray);

            //throw new NotImplementedException();
        }

        /// <summary>
        /// Replaces all spaces in a word with char.  Case sensitive.  Replaces pre and trailing spaces
        /// </summary>
        /// <param name="word"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public string ReplaceSpace(string word, char c) {

            return word.Replace(" ", c.ToString());
            //throw new NotImplementedException();
        }
    }
}
