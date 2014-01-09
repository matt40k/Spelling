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
    public class WordCase
    {
        [TestMethod]
        public void WordCase_ToUpper()
        {
            string name = "dad";
            string validName = "DAD";

            var logic = new Logic();
            string result = logic.NameToUpper(name);
            Assert.AreEqual(result, validName, "Word should be in all capitals!");
        }

        [TestMethod]
        public void WordCase_ToLower()
        {
            string name = "dAd";
            string validName = "dad";

            var logic = new Logic();
            string result = logic.NameToLower(name);
            Assert.AreEqual(result, validName, "Word should be in all lower case!");
        }

        [TestMethod]
        public void WordCase_ToCamel()
        {
            string name = "dAd";
            string validName = "Dad";

            var logic = new Logic();
            string result = logic.NameToCamel(name);
            Assert.AreEqual(result, validName, "Word should be");
        }

        [TestMethod]
        public void WordCase_ToCamel_Failure()
        {
            string name = "dAd";
            string validName = "DAD";

            var logic = new Logic();
            string result = logic.NameToCamel(name);
            Assert.AreNotEqual(result, validName, "Word should be");
        }
    }
}