﻿/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class LetterUpperLower
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void LetterUpperLower_InvalidLength()
        {
            string invalidLetter = "dad";

            Logic logic = new Logic();
            string upperLower = logic.GetCharacterUpperLowerCombined(invalidLetter);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void LetterUpperLower_Null()
        {
            Logic logic = new Logic();
            string upperLower = logic.GetCharacterUpperLowerCombined(null);
        }

        [TestMethod]
        public void LetterUpperLower_FromUpperA()
        {
            string validLetter = "A";

            Logic logic = new Logic();
            string upperLower = logic.GetCharacterUpperLowerCombined(validLetter);
            Assert.AreEqual("Aa", upperLower, "Should return Aa!");
        }

        [TestMethod]
        public void LetterUpperLower_ToLowerZ()
        {
            string validLetter = "z";

            Logic logic = new Logic();
            string upperLower = logic.GetCharacterUpperLowerCombined(validLetter);
            Assert.AreEqual("Zz", upperLower, "Should return Zz!");
        }
    }
}
