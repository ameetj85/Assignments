using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleverDevicesStack
{
    /// <summary>
    /// This class is a custom implementation 
    /// of the built in C# Stack object.
    /// This class uses an Array to implement
    /// PUSH, POP and PEEK methods.
    /// </summary>
    public class CustomStack : ICustomStackObject
    {
        public int StackSize { get; set; }
        public int topIndex;
        Object[] stackItem;

        public CustomStack()
        {
            StackSize = 10; // default if no capacity is provided
            stackItem = new Object[StackSize];
            topIndex = -1;
        }

        public CustomStack(int capacity)
        {
            StackSize = capacity;
            stackItem = new Object[StackSize];
            topIndex = -1;            
        }
        public void Display()
        {
            for (int i = topIndex; i > -1; i--)
            {   
                Console.WriteLine("Item {0}: Value:[{1}] Type:[{2}]", (i + 1), stackItem[i], (stackItem[i] == null ? "null" : stackItem[i].GetType().ToString()));
            }
        }

        public bool isEmpty()
        {
            return topIndex == -1 ? true : false;
        }

        public object Peek()
        {
            if (isEmpty())
            {
                return "No elements";
            }
            else
            {
                return stackItem[topIndex];
            }
        }

        public object Pop()
        {
            if (isEmpty())
            {
                return "No elements";
            }
            else
            {
                object val = stackItem[topIndex];
                Array.Resize(ref stackItem, topIndex--);//resize the array to new size
                StackSize = stackItem.Count();
                return val;
            }
        }

        public void Push(object element)
        {
            if (topIndex < (StackSize - 1))
            {
                stackItem[++topIndex] = element;
            }
        }
    }
}
