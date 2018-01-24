using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverDevicesSentenceReverserTest
{
    public class StringReverser
    {
        public string ReverseAString(string originalString)
        {
            string inputString = originalString;
            string[] words = inputString.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        
    }
}
