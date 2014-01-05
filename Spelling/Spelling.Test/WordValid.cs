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
    public class WordValid
    {
        [TestMethod]
        public void WordValid_IsValid()
        {
            string validWord = "dad";

            Logic logic = new Logic();
            bool wordValid = logic.IsValidWord(validWord);
            Assert.AreEqual(true, wordValid, "Word is not validating correctly!");
        }

        [TestMethod]
        public void WordValid_IsNotValid_TooLong()
        {
            string validWord = "supercalifragilisticexpialidocious";

            Logic logic = new Logic();
            bool wordValid = logic.IsValidWord(validWord);
            Assert.AreEqual(false, wordValid, "Word is not validating correctly!");
        }
    }
}
