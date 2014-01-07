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

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class WordNameFromFilename
    {
        [TestMethod]
        public void WordNameFromFilename_FileNameAndExtension()
        {
            string fileName = "dad.png";
            string validFileName = "dad";

            Logic logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }

        [TestMethod]
        public void WordNameFromFilename_FileName()
        {
            string fileName = "dad";
            string validFileName = "dad";

            Logic logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }

        [TestMethod]
        public void WordNameFromFilename_FileNameWithPath()
        {
            string fileName = @"c:\tmp\dad";
            string validFileName = "dad";

            Logic logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }

        [TestMethod]
        public void WordNameFromFilename_FileNameWithExtensionAndPath()
        {
            string fileName = @"c:\tmp\dad.png";
            string validFileName = "dad";

            Logic logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }
    }
}
