using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverDevicesFindCommonCharsInTwoStrings
{
    public class FindCommonChars
    {
        public IEnumerable<string> FindCommonCharactersInTwoStrings(string inputOne, string inputTwo)
        {
            string[] arrayOne = inputOne.ToCharArray().Select(c => c.ToString()).ToArray();
            string[] arrayTwo = inputTwo.ToCharArray().Select(c => c.ToString()).ToArray();

            var distinctCharsInString1 = arrayOne.Distinct();
            var distinctCharsInString2 = arrayTwo.Distinct();

            return distinctCharsInString1.Intersect(distinctCharsInString2, StringComparer.OrdinalIgnoreCase);
        }
    }
}
