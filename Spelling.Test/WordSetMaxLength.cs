﻿/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class WordSetMaxLength
    {
        [TestMethod]
        public void WordSetMaxLength_SetNull()
        {
            var logic = new Logic();
            logic.SetMaxLength = null;
            Assert.AreEqual(5, logic.GetMaxLength, "Word max length cannot be null!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetZero()
        {
            var logic = new Logic();
            logic.SetMaxLength = 0;
            Assert.AreEqual(5, logic.GetMaxLength, "Word max length cannot be zero!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetTwo()
        {
            var logic = new Logic();
            logic.SetMaxLength = 2;
            Assert.AreEqual(2, logic.GetMaxLength, "Word max length should be 2!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetFive()
        {
            var logic = new Logic();
            logic.SetMaxLength = 5;
            Assert.AreEqual(5, logic.GetMaxLength, "Word length should be 5!");
        }

        [TestMethod]
        public void WordSetMaxLength_SetTwelve()
        {
            var logic = new Logic();
            logic.SetMaxLength = 12;
            Assert.AreEqual(12, logic.GetMaxLength, "Word length should be 12!");
        }
    }
}