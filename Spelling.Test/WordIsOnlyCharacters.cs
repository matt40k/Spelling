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
    public class WordIsOnlyCharacters
    {
        [TestMethod]
        public void WordIsOnlyCharacters_IsValid()
        {
            const string name = "dad";

            var logic = new Logic();
            bool _valid = logic.IsOnlyCharacters(name);
            Assert.AreEqual(true, _valid, "Word should be valid!");
        }

        [TestMethod]
        public void WordIsOnlyCharacters_IsNotValid()
        {
            const string name = "dad1";

            var logic = new Logic();
            bool _valid = logic.IsOnlyCharacters(name);
            Assert.AreEqual(false, _valid, "Word should be valid!");
        }
    }
}