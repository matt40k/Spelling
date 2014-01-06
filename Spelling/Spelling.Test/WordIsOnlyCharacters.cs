using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matt40k.Spelling.Test
{
    [TestClass]
    public class WordIsOnlyCharacters
    {
        [TestMethod]
        public void WordIsOnlyCharacters_IsValid()
        {
            string name = "dad";

            Logic logic = new Logic();
            bool _valid = logic.IsOnlyCharacters(name);
            Assert.AreEqual(true, _valid, "Word should be valid!");
        }

        [TestMethod]
        public void WordIsOnlyCharacters_IsNotValid()
        {
            string name = "dad1";

            Logic logic = new Logic();
            bool _valid = logic.IsOnlyCharacters(name);
            Assert.AreEqual(false, _valid, "Word should be valid!");
        }
    }
}
