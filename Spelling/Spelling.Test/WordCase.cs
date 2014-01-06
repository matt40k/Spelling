using System;
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

            Logic logic = new Logic();
            string result = logic.NameToUpper(name);
            Assert.AreEqual(result, validName, "Word should be in all capitals!");
        }

        [TestMethod]
        public void WordCase_ToLower()
        {
            string name = "dAd";
            string validName = "dad";

            Logic logic = new Logic();
            string result = logic.NameToLower(name);
            Assert.AreEqual(result, validName, "Word should be in all lower case!");
        }

        [TestMethod]
        public void WordCase_ToCamel()
        {
            string name = "dAd";
            string validName = "Dad";

            Logic logic = new Logic();
            string result = logic.NameToCamel(name);
            Assert.AreEqual(result, validName, "Word should be");
        }

        [TestMethod]
        public void WordCase_ToCamel_Failure()
        {
            string name = "dAd";
            string validName = "DAD";

            Logic logic = new Logic();
            string result = logic.NameToCamel(name);
            Assert.AreNotEqual(result, validName, "Word should be");
        }
    }
}
