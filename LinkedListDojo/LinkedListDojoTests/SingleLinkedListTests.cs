using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo.Tests
{
    [TestClass()]
    public class SingleLinkedListTests
    {
        [TestMethod()]
        public void SingleLinkedListTest()
        {
            SingleLinkedList < string > single= new SingleLinkedList<string>();
            Assert.IsNotNull(single);
        }

        [TestMethod()]
        public void SingleLinkedListTest1()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>("item");

            Assert.IsNotNull(single.head);
        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            Assert.AreEqual(true, single.IsEmpty());
        }

        [TestMethod()]
        public void IsEmptyTest2()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>("item");
            Assert.AreEqual(false, single.IsEmpty());
        }

        [TestMethod()]
        public void AddTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            Assert.AreEqual("item",single.last.value);
        }

        [TestMethod()]
        public void AddTestMultipleItems()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Add("item2");
            Assert.AreEqual("item2", single.last.value);
        }

        [TestMethod()]
        public void AddTestMultipleItemFirstStillSame()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Add("item2");
            Assert.AreEqual("item", single.head.value);
        }

        [TestMethod()]
        public void AddNodeReferencesAreCorrectTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Add("item2");
            Assert.AreEqual("item2", single.head.next.value);
        }

        [TestMethod()]
        public void LengthWithZeroItemsTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            Assert.AreEqual(0, single.lenght);
        }

        [TestMethod()]
        public void LengthWithMultipleItemsTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Add("item2");
            Assert.AreEqual(2, single.lenght);
        }


        [TestMethod()]
        public void RemoveIsWorkingTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Remove("item");
            Assert.AreEqual(true, single.IsEmpty());
        }

        [TestMethod()]
        public void RemoveIsWorkingWithMultipleElementTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Add("item2");
            single.Add("item3");
            single.Remove("item3");
            Assert.AreEqual("item2", single.last.value);
        }

        [TestMethod()]
        public void RemoveIsWorkingWitChangedHeadTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Add("item2");
            single.Add("item3");
            single.Remove("item");
            Assert.AreEqual("item2", single.head.value);
        }

        [TestMethod()]
        public void RemoveIsWorkingWitValuesTest()
        {
            SingleLinkedList<string> single = new SingleLinkedList<string>();
            single.Add("item");
            single.Add("item2");
            single.Add("item3");
            single.Add("item4");
            single.Remove("item2");
            Assert.AreEqual("item3", single.head.next.value);
        }
    }
}