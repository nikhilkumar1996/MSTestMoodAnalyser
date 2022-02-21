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
        [TestMethod]
        public void TestNullMood()
        {
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            string comapre = "happy";
            string expected = mood.AnalyzeMood();
            Assert.AreEqual(comapre, expected);
        }
        [TestMethod]
        public void TestCustomNullException()
        {
            string compare = "Mood should not be Null";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                moodAnalyser.AnalyzeMood();
            }
            catch(CustomException ex)
            {
                Assert.AreEqual(compare, ex.Message);
            }
        }
        [TestMethod]
        public void TestCustomEmptyException()
        {
            string compare = "Mood should not be empty";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(compare, ex.Message);
            }
        }
    }
}