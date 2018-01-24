using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleverDevicesStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverDevicesStack.Tests
{
    [TestClass()]
    public class CustomStackTests
    {
        public int StackSize { get; set; }
        public int topIndex;
        Object[] stackItem;

        [TestMethod()]
        public void CustomStackTest()
        {
            StackSize = 10; // default if no capacity is provided
            stackItem = new Object[StackSize];
            topIndex = -1;

            Assert.AreEqual(stackItem.GetType(), typeof(Object[]));
            
        }

        
        [TestMethod()]
        public void InitialItemCount()
        {
            stackItem = new Object[StackSize];
            Assert.IsFalse(stackItem.Count() > 0);
        }


        [TestMethod()]
        public void PushTest()
        {
            var element = "My element";
            StackSize = 10;
            topIndex = 0;

            stackItem = new Object[StackSize];
            if (topIndex < (StackSize - 1))
            {
                stackItem[++topIndex] = element;
            }

            Assert.AreEqual(stackItem.Count(), StackSize);
        }

        [TestMethod()]
        public void PopTest2()
        {
            StackSize = 10;
            topIndex = 0;
            stackItem = new Object[StackSize];

            while (topIndex < (StackSize - 1))
            {
                stackItem[++topIndex] = "item " + topIndex;
            }

            var element = stackItem[9];

            Assert.AreNotEqual(element, "item 5");
        }

        
        [TestMethod()]
        public void PopTest()
        {
            StackSize = 10;
            topIndex = 0;
            stackItem = new Object[StackSize];

            while (topIndex < (StackSize - 1))
            {
                stackItem[++topIndex] = "item " + topIndex;
            }

            var element = stackItem[5];

            Assert.AreEqual(element, "item 5");
        }

        [TestMethod]
        public void isEmptyTest()
        {
            StackSize = 10;
            topIndex = 0;
            stackItem = new Object[StackSize];

            while (topIndex < (StackSize - 1))
            {
                stackItem[++topIndex] = "item " + topIndex;
            }

            while (topIndex >= 0)
                Array.Resize(ref stackItem, topIndex--);

            Assert.AreEqual(stackItem.Count(), 0);
        }
    }
}