/*
 * Developer : Matt Smith (matt@matt40k.co.uk)
 * All code (c) Matthew Smith all rights reserved
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matt40k.Spelling;

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class WordLength
    {
        [TestMethod]
        public void WordLength_WithValidLength()
        {
            string validWord = "dad";
            int? validLength = 3;

            Logic logic = new Logic();
            int? wordLength = logic.GetWordLength(validWord);
            Assert.AreEqual(validLength, wordLength, "Word length is not validating correctly!");
        }

        [TestMethod]
        public void WordLength_WithNull()
        {
            string validWord = null;
            int? validLength = null;

            Logic logic = new Logic();
            int? wordLength = logic.GetWordLength(validWord);
            Assert.AreEqual(validLength, wordLength, "Word length is not validating correctly - It should be null!");
        }
    }
}
