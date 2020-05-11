using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace LeetSpeak.TestTools{
    [TestClass]
    public class LeetSpeakTests
    {
        [TestMethod]
        
        public void LeetTranslate_eto3()
        {
             LeetspeakTranslator testLeetSpeakTranslator = new LeetspeakTranslator();
            
            Assert.AreEqual("3", testLeetSpeakTranslator.Translate("e"));
        }

        [TestMethod]
        
        public void LeetTranslate_ztos()
        {
             LeetspeakTranslator testLeetSpeakTranslator = new LeetspeakTranslator();
            
            Assert.AreEqual("z", testLeetSpeakTranslator.Translate("s"));
        }
    }
}