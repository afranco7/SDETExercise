using System;
using System.Linq;

namespace SDETExercise
{
    /// <summary>
    /// Util class for Sdet
    /// </summary>
    public class SdetUtilz
    {
        /// <summary>
        /// This method returns the LongestWord from a given sentence
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public string LongestWord(string sentence)
        {
            if (!string.IsNullOrEmpty(sentence))
            {
                string[] words = sentence.Split(' ').Select(str => str.Trim()).ToArray();

                int maxLength = words.Max(x => x.Length);
                string longestString = words.Where(x => x.Length == maxLength).First();

                return maxLength + " " + longestString;
            }
            else
            {
                throw new ArgumentException("Invalid argument");
            }            
        }
    }
}
