using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class StringUtility
    {
        public static string SummarizeText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
            {
                return sentence;
            }

            var words = sentence.Split(' ');
            var totalChars = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChars += word.Length + 1;
                if (totalChars > maxLength)
                {
                    break;
                }
            }

            //var summary = String.Join(" ", summaryWords) + "...";
            return String.Join(" ", summaryWords) + "...";
            //sentence.Substring(0, maxLength);

        }
    }
}
