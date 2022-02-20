using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProgram;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        
        
        [TestMethod]
        public void TestHappyMood()
        {
            string message = "I am in happy mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string compare = "happy";
            string expected =mood.AnalyzeMood();
            Assert.AreEqual(compare, expected);
        }
        [TestMethod]
        public void TestSadMood()
        {
            string message = "I am in sad mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string compare = "sad";
            string expected = mood.AnalyzeMood();
            Assert.AreEqual(compare, expected);

        }
    }
}