using System;

namespace CleverDevicesSentenceReverserTest
{
    /// <summary>
    /// Acquire a string of words and 
    /// return a string with the words in reversed order.
    /// </summary>
    public class StringReverser
    {
        public string ReverseWordsInASentence(string originalString)
        {
            string inputString = originalString;
            
            // Convert to array so that we can use the Reverse() method
            string[] words = inputString.Split(' ');
            Array.Reverse(words);
            
            // The Join statement adds the space back between each word
            return string.Join(" ", words);

            
        }
        
    }
}
