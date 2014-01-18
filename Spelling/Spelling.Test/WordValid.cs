/*
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
    public class WordValid
    {
        [TestMethod]
        public void WordValid_IsValid()
        {
            const string validWord = "dad";

            var logic = new Logic();
            bool wordValid = logic.IsValidWord(validWord);
            Assert.AreEqual(true, wordValid, "Word is not validating correctly!");
        }

        [TestMethod]
        public void WordValid_IsNotValid_TooLong()
        {
            const string invalidWord = "supercalifragilisticexpialidocious";

            var logic = new Logic();
            bool wordValid = logic.IsValidWord(invalidWord);
            Assert.AreEqual(false, wordValid, "Word is too long!");
        }

        [TestMethod]
        public void WordValid_IsNotValid_ContainsNumbers()
        {
            const string invalidWord = "qwe123";

            var logic = new Logic();
            bool wordValid = logic.IsValidWord(invalidWord);
            Assert.AreEqual(false, wordValid, "Word contains numbers!");
        }

        [TestMethod]
        public void WordValid_IsNotValid_ContainsSpecialCharacters()
        {
            const string invalidWord = "Sup3rM@n";

            var logic = new Logic();
            bool wordValid = logic.IsValidWord(invalidWord);
            Assert.AreEqual(false, wordValid, "Word contains numbers!");
        }
    }
}