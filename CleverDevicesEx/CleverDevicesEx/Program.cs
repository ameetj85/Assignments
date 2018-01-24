using CleverDevicesFactorsNumbers;
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
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            if (args.Count() > 0)
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
                        case 1: RunSentenceReverserTest(); Console.ReadLine(); break;
                        case 2: RunStackTest(); Console.ReadLine(); break;
                        case 3: RunCustomStackTest(); break;
                        case 4: RunFindCommonLettersInTwoStringsTest(); Console.ReadLine(); break;
                        case 5: RunFibonacciSequenceTest(); break;
                        case 6: RunactorsTest(); break;
                    }
                }
                else
                    return 0;
            }
        }



        /// <summary>
        /// The UnhandledExceptionTrapper() method sets up a system-wide
        /// exception trapper that will catch all exceptions that
        /// occur after the code execution enters the Main() method.
        /// The errors will be displayed in the console output
        /// window and the application will let the user know that
        /// it will exit.
        ///</summary>
        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("An error has occurred. In order to not cause any damage, the application will now exit.");
            Console.WriteLine("The cause of the error is displayed below.");
            Console.WriteLine();
            Console.WriteLine(e.ExceptionObject.ToString());
            Environment.Exit(1);
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select one option by its number and hit enter. Any other key to exit.");
            Console.WriteLine("1. Run the \"reverse the order of words in a sentence\" test.");
            Console.WriteLine("2. Run the C# Stack - Pop, Push, Peek, IsEmpty test.");
            Console.WriteLine("3. Run the custom implementation of Stack - Pop, Push, Peek, IsEmpty test.");
            Console.WriteLine("4. Run the \"find matching chracters in two strings\" test");
            Console.WriteLine("5. Run the \"fibonacci sequence\" test");
            Console.WriteLine("6. Run the \"factors of a number\" test");
        }

        /// <summary>
        /// Acquire a string of words and 
        /// return a string with the words in reversed order.
        /// </summary>
        private static void RunSentenceReverserTest()
        {
            string strSentence = "";

            Console.WriteLine("Please enter a sentence to reverse and press enter.");
            strSentence = Console.ReadLine();

            if (strSentence.Trim().Length == 0)
                return;

            CleverDevicesSentenceReverserTest.StringReverser stringReverser = new CleverDevicesSentenceReverserTest.StringReverser();
            Console.WriteLine(stringReverser.ReverseWordsInASentence(strSentence));
        }

        /// <summary>
        /// Implement a class that uses the Stack of T 
        /// functionality that is built into the dotNet framework.
        /// Includes support for Push, Pop, Peek and Size 
        /// </summary>
        private static void RunStackTest()
        {
            Console.Clear();
            Console.WriteLine("Creating a Stack of objects (PUSH).");

            Stack<object> objStack = new Stack<object>();
            objStack.Push("Hello");
            objStack.Push("World");
            objStack.Push(null);
            objStack.Push(1);
            objStack.Push(2);
            objStack.Push(3);
            objStack.Push(4);
            objStack.Push(5);
            objStack.Push(DateTime.Now);

            Console.WriteLine("\r\nDisplaying contents of the stack.");
            foreach (var itm in objStack)
                Console.WriteLine("Value: [{0}] - Type: [{1}]", itm, (itm == null ? "null" : itm.GetType().ToString()));

            Console.WriteLine("\r\nNumber of items in the Stack (SIZE): {0}", objStack.Count);

            Console.WriteLine("\r\nPOPping items from the Stack.");
            while (objStack.Count > 0)
                Console.WriteLine(objStack.Pop());

            Console.WriteLine("\r\nNumber of items in the Stack: {0}", objStack.Count);

        }

        /// <summary>
        /// A custom implementation of the built in C# Stack object,
        /// using an array.
        /// Demonstrates support for PUSH, POP and PEEK methods.
        /// </summary>
        private static void RunCustomStackTest()
        {
            Console.Clear();
            Console.WriteLine("Creating a Stack of objects (PUSH) using custom stack implementation.");

            CleverDevicesStack.CustomStack objStack = new CleverDevicesStack.CustomStack(9);

            objStack.Push("Hello");
            objStack.Push("World");
            objStack.Push(null);
            objStack.Push(1);
            objStack.Push(2);
            objStack.Push(3);
            objStack.Push(4);
            objStack.Push(5);
            objStack.Push(DateTime.Now);

            Console.WriteLine("\r\nDisplaying contents of the stack.");
            objStack.Display();

            Console.WriteLine("\r\nPOPping stack items.");
            Console.WriteLine("\r\nNumber of items in the Stack (SIZE): {0}", objStack.StackSize);

            while (!objStack.isEmpty())
                Console.WriteLine(objStack.Pop());

            Console.WriteLine("\r\nNumber of items in the Stack (SIZE): {0}", objStack.StackSize);

            Console.ReadLine();
        }

        /// <summary>
        /// Acquire two strings of letters
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

        /// <summary>
        /// This method acquires an integer input
        /// and then computes a fibonacci sequnce for it.
        /// The fibonacci sequence is returns as a list of ints
        /// </summary>
        private static void RunFibonacciSequenceTest()
        {
            Console.WriteLine("Please enter a number for which to compute the fibonacci sequence and press enter.");
            int fValue = 0;
            string input = Console.ReadLine();
            int.TryParse(input, out fValue);

            if (fValue > 0)
            {
                Console.WriteLine("The sequence is as follows:");
                CleverDevicesFibonacci.FibonacciCompute fCompute = new CleverDevicesFibonacci.FibonacciCompute();
                List<int> sequence = fCompute.Fibonacci(fValue);
                if (sequence.Any())
                {
                    foreach (int val in sequence)
                        Console.WriteLine(val);
                }

                Console.WriteLine("Press ENTER to continue ...");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// This test takes in one number an produces 
        /// a sequence of "factors".
        /// Factors of a number are all those numbers
        /// that can divide evenly into the number
        /// with no remainder.
        /// </summary>
        private static void RunactorsTest()
        {
            Console.WriteLine("Please enter a number for which to compute the factors sequence and press enter.");
            int fValue = 0;
            string input = Console.ReadLine();
            int.TryParse(input, out fValue);

            if (fValue > 0)
            {
                ComputeFactors computeFactros = new ComputeFactors();
                List<int> factorValues = computeFactros.FactorsCompute(fValue);

                if (factorValues.Any())
                {
                    Console.WriteLine("The folowwing are the factors for " + fValue);

                    foreach (int val in factorValues)
                        Console.WriteLine(val);
                }
            }

            Console.WriteLine("Press ENTER to continue ...");
            Console.ReadLine();
        }
    }        
}
