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
