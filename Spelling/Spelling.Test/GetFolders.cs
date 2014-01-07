/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 */

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class GetFolders
    {
        [TestMethod]
        public void GetFolders_Valid_ReturnMagicGate()
        {
            Logic logic = new Logic();
            List<string> result = logic.GetFolderNames;

            string validFolder = "The Magic Key";
            string resultFolder = result[0];

            Assert.AreEqual(validFolder, resultFolder, "Should return MagicKey!");
        }

        /*
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void GetFolders_Invalid_Null()
        {

        }

        [TestMethod]
        public void GetFolders_Invalid_MoreThenOne()
        {
            Logic logic = new Logic();
            List<string> result = logic.GetFolders;

            Assert.AreEqual(1, result.Count, "Should return only one!");
        }*/
    }
}
