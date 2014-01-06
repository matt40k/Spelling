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
            List<string> result = logic.GetFolders;

            string validFolder = "MagicKey";
            string resultFolder = result[0].Substring(result[0].LastIndexOf("\\") + 1);

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
