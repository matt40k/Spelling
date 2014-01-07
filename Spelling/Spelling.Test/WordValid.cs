/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
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
            string invalidWord = "supercalifragilisticexpialidocious";

            Logic logic = new Logic();
            bool wordValid = logic.IsValidWord(invalidWord);
            Assert.AreEqual(false, wordValid, "Word is too long!");
        }

        [TestMethod]
        public void WordValid_IsNotValid_ContainsNumbers()
        {
            string invalidWord = "qwe123";

            Logic logic = new Logic();
            bool wordValid = logic.IsValidWord(invalidWord);
            Assert.AreEqual(false, wordValid, "Word contains numbers!");
        }

        [TestMethod]
        public void WordValid_IsNotValid_ContainsSpecialCharacters()
        {
            string invalidWord = "Sup3rM@n";

            Logic logic = new Logic();
            bool wordValid = logic.IsValidWord(invalidWord);
            Assert.AreEqual(false, wordValid, "Word contains numbers!");
        }
    }
}
