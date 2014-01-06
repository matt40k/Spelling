using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class WordSetMaxLength
    {
        [TestMethod]
        public void WordSetMaxLength_SetNull()
        {
            Logic logic = new Logic();
            logic.SetMaxLength = null;
            Assert.AreEqual(5, logic.GetMaxLength, "Word max length cannot be null!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetZero()
        {
            Logic logic = new Logic();
            logic.SetMaxLength = 0;
            Assert.AreEqual(5, logic.GetMaxLength, "Word max length cannot be zero!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetTwo()
        {
            Logic logic = new Logic();
            logic.SetMaxLength = 2;
            Assert.AreEqual(2, logic.GetMaxLength, "Word max length should be 2!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetFive()
        {
            Logic logic = new Logic();
            logic.SetMaxLength = 5;
            Assert.AreEqual(5, logic.GetMaxLength, "Word length should be 5!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetTwelve()
        {
            Logic logic = new Logic();
            logic.SetMaxLength = 12;
            Assert.AreEqual(12, logic.GetMaxLength, "Word length should be 12!");
        }
    }
}
