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
    public class WordIsValidFileType
    {
        [TestMethod]
        public void WordIsValidFileType_Valid_PNG()
        {
            const string validFileType = "image.png";

            var logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause PNG is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Valid_JPG()
        {
            const string validFileType = "image.jpg";

            var logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause JPG is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Valid_BMP()
        {
            const string validFileType = "image.bmp";

            var logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause BMP is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Valid_GIF()
        {
            const string validFileType = "image.gif";

            var logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(true, result, "Should return true, cause GIF is supported!");
        }

        [TestMethod]
        public void WordIsValidFileType_Invalid_DOC()
        {
            const string validFileType = "image.doc";

            var logic = new Logic();
            bool result = logic.IsValidFileType(validFileType);
            Assert.AreEqual(false, result, "Should return false, cause DOC is not supported!");
        }
    }
}