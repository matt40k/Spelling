using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class WordIsValidFileType
    {
        [TestMethod]
        public void WordIsValidFileType_Valid_PNG()
        {
            string validFileType = "image.png";

            Logic logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause PNG is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Valid_JPG()
        {
            string validFileType = "image.jpg";

            Logic logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause JPG is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Valid_BMP()
        {
            string validFileType = "image.bmp";

            Logic logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause BMP is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Valid_GIF()
        {
            string validFileType = "image.gif";

            Logic logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause GIF is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Invalid_DOC()
        {
            string validFileType = "image.doc";

            Logic logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(false, result, "Should return false, cause DOC is not supported!");
        }
    }
}
