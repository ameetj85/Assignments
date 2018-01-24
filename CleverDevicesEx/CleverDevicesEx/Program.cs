using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleverDevicesEx
{
    class Program
    {
        private static int intOption;

        static int Main(string[] args)
        {
            if(args.Count() > 0)
            {
                Console.WriteLine("Command line arguments are not supported.");
                return -1;
            }

            while (true)
            {
                DisplayMenu();
                string option = Console.ReadLine();

                if (int.TryParse(option, out intOption))
                {
                    switch (intOption)
                    {
                        case 1: RunReverserTest(); Console.ReadLine();  break;
                        case 2: RunStackTest(); Console.ReadLine(); break;
                        case 3: RunFindCommonLettersInTwoStringsTest(); Console.ReadLine(); break;
                        default: return 0; 
                    }
                }
                else
                    return 0;
            }            
        }

        
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select one option by its number and hit enter. Any other key to exit.");
            Console.WriteLine("1. Run the reverse order of words in a sentence test.");
            Console.WriteLine("2. Run the Stack - Pop, Push, Peek, IsEmpty test.");
            Console.WriteLine("3. Run the \"find matching chracters in two strings\" test");
        }

        /// <summary>
        /// Acquire a string of words and 
        /// return a string with the words in reversed order.
        /// </summary>
        private static void RunReverserTest()
        {            
            string strOne = "";
            
            Console.WriteLine("Please enter a sentence to reverse and press enter.");
            strOne = Console.ReadLine();

            if (strOne.Trim().Length == 0)
                return;

            CleverDevicesSentenceReverserTest.StringReverser stringReverser = new CleverDevicesSentenceReverserTest.StringReverser();
            Console.WriteLine(stringReverser.ReverseAString(strOne));            
        }

        /// <summary>
        /// Implement a class that uses the Stack of T 
        /// functionality.
        /// Includes support for Push, Pop, Size 
        /// & isEmpty
        /// https://www.dotnetperls.com/stack
        /// https://msdn.microsoft.com/en-us/library/6335ax0f(v=vs.110).aspx
        /// http://www.tutorialsteacher.com/csharp/csharp-stack
        /// </summary>
        private static void RunStackTest()
        {
            Stack<object> myStack = new Stack<object>();
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            foreach (var itm in myStack)
                Console.Write(itm);
        }

        /// <summary>
        /// Acquire two sets of letters
        /// and find the letters that are 
        /// common between both
        /// </summary>
        private static void RunFindCommonLettersInTwoStringsTest()
        {
            var strOne = "";
            var strTwo = "";

            Console.WriteLine("Please enter the first string of letters and press enter.");
            strOne = Console.ReadLine();

            Console.WriteLine("Please enter the second string of letters and press enter.");
            strTwo = Console.ReadLine();

            if ((strOne.Trim().Length == 0) || (strTwo.Trim().Length == 0))
                return;

            CleverDevicesFindCommonCharsInTwoStrings.FindCommonChars findCommonChars = 
                new CleverDevicesFindCommonCharsInTwoStrings.FindCommonChars();

            var results = findCommonChars.FindCommonCharactersInTwoStrings(strOne, strTwo);

            if (results.Any())
            {
                Console.Write("The following are the letters that are common to both strings: ");
                foreach (var c in results)
                    Console.Write(c + " ");
            }

                Console.WriteLine();
         }
    }
}
