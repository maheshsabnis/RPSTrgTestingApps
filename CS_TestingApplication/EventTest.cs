using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS_TestingApplication
{
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void OverBalanceEventTest()
        {
            CS_ApplicationForTesting.Banking bank
                    = new CS_ApplicationForTesting.Banking(80000);
            // creating list that will record the event name when it is fired
            List<string> eventsList = new List<string>();
            bank.OverBalance += delegate(int amount) 
            {
                eventsList.Add("OverBalance");
            };
            // call the method that will raise the event
            // based on the input data
            bank.Deposit(3000);
            // Assertion on the result
            CollectionAssert.Contains(eventsList, "OverBalance");
        }

         
    }
}
