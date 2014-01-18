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
    public class WordNameFromFilename
    {
        [TestMethod]
        public void WordNameFromFilename_FileNameAndExtension()
        {
            const string fileName = "dad.png";
            const string validFileName = "dad";

            var logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }

        [TestMethod]
        public void WordNameFromFilename_FileName()
        {
            const string fileName = "dad";
            const string validFileName = "dad";

            var logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }

        [TestMethod]
        public void WordNameFromFilename_FileNameWithPath()
        {
            const string fileName = @"c:\tmp\dad";
            const string validFileName = "dad";

            var logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }

        [TestMethod]
        public void WordNameFromFilename_FileNameWithExtensionAndPath()
        {
            const string fileName = @"c:\tmp\dad.png";
            const string validFileName = "dad";

            var logic = new Logic();
            string wordFileName = logic.GetWordNameFromFilename(fileName);
            Assert.AreEqual(wordFileName, validFileName, "Word name from Filename is not working correctly!");
        }
    }
}