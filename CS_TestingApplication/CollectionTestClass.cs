using CS_ApplicationForTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TestingApplication
{
    [TestClass]
    public class CollectionTestClass
    {
        [TestMethod]
        public void CollectionReferenceEqualTest()
        {
            List<string> lst1 = new List<string>();
            List<string> lst2 = new List<string>();
            CollectionAssert.ReferenceEquals(lst1, lst2);
        }

        [TestMethod]
        public void CheckTheReturnInstaceTypeTest()
        {
            Test tResult = CS_ApplicationForTesting.Program.AddTest();
            Assert.IsInstanceOfType(tResult, typeof(Test));
        }

        [TestMethod]
        public void CollectionEqualityTest()
        {
            List<string> lst1 = new List<string>();
            lst1.Add("Mahesh");
            lst1.Add("Sabnis");
            List<string> lst2 = new List<string>();
            lst2.Add("Mahesh");
            lst1.Add("Mahesh");
            // Compare collections based on length of
            // data present in it
            CollectionAssert.AreEqual(lst1, lst2);
        }

        [TestMethod]
        public void CollectionEquivalencyTest()
        {
            List<string> lst1 = new List<string>();
            lst1.Add("Mahesh");
            lst1.Add("Sabnis");
            List<string> lst2 = new List<string>();
            lst2.Add("Mahesh");
            lst2.Add("Sabnis");
            CollectionAssert.AreEquivalent(lst1,lst2);
        }


        [TestMethod]
        public void NonGenericCollectionTest()
        {
            ArrayList arr = new ArrayList();
            arr.Add("A");
            arr.Add("B");
            arr.Add(100);
            CollectionAssert.AllItemsAreInstancesOfType(arr, typeof(string),
                  "All Items are not same");
        }

        [TestMethod]
        public void GenericCollectionTest()
        {
            List<string> arr = new List<string>();
            arr.Add("A");
            arr.Add("B");
            arr.Add(" ");
            arr.Add(null);
            // still test works successfully becuase string is reference type
            CollectionAssert.AllItemsAreInstancesOfType(arr, typeof(string),
                  "All Items are not same");
        }

        [TestMethod]
        public void GenericCollectionNotNullTest()
        {
            List<string> arr = new List<string>();
            arr.Add("A");
            arr.Add("B");
            arr.Add(" ");
            arr.Add(null);
            // make sure that the collection does not have null entry
            CollectionAssert.AllItemsAreNotNull(arr);
        }

        [TestMethod]
        public void GenericCollectionUniqueValueTest()
        {
            List<string> arr = new List<string>();
            arr.Add("A");
            arr.Add("B");
            arr.Add("C");
            arr.Add("C");
            // Test Fails because "C" is duplicate
            CollectionAssert.AllItemsAreUnique(arr);
        }

        [TestMethod]
        public void GenericCollectionUniqueObjectTest()
        {
            List<Test> lstTests = new List<Test>();
            //lstTests.Add(new Test() {Id=1,Name="T1" });
            //lstTests.Add(new Test() { Id = 2, Name = "T2" });
            //lstTests.Add(new Test() { Id = 3, Name = "T3" });
            //lstTests.Add(new Test() { Id = 3, Name = "T3" });
            var t1 = new Test() { Id = 1, Name = "T1" };
            lstTests.Add(t1);
            var t2 = new Test() { Id = 2, Name = "T2" };
            lstTests.Add(t2);
            lstTests.Add(t2);

            CollectionAssert.AllItemsAreUnique(lstTests);
        }

        [TestMethod]
        public void GenericCollectionValueContainTest()
        {
            List<string> arr = new List<string>();
            arr.Add("A");
            arr.Add("B");
            arr.Add("C");
            //  CollectionAssert.Contains(arr, "A");
            // CollectionAssert.Contains(arr, "E");
            CollectionAssert.DoesNotContain(arr, "E");

        }

    }
}
