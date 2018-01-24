using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverDevicesFindCommonCharsInTwoStrings
{
    /// <summary>
    /// Acquire two strings of letters
    /// and find the letters that are 
    /// common between both
    /// </summary>
    public class FindCommonChars
    {
        public IEnumerable<string> FindCommonCharactersInTwoStrings(string inputOne, string inputTwo)
        {
            // Convert the two input strings to char arrays
            string[] arrayOne = inputOne.ToCharArray().Select(c => c.ToString()).ToArray();
            string[] arrayTwo = inputTwo.ToCharArray().Select(c => c.ToString()).ToArray();

            // remove any duplicate chars
            var distinctCharsInString1 = arrayOne.Distinct();
            var distinctCharsInString2 = arrayTwo.Distinct();

            // array of strings allows us to use the "intersect" op to find common chars
            return distinctCharsInString1.Intersect(distinctCharsInString2, StringComparer.OrdinalIgnoreCase);
        }
    }
}
