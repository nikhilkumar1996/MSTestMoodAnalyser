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
        public void TestCustomNullException()
        {
            string compare = "Mood should not be null";
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string expected = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(compare, expected);

        }
        [TestMethod]
        public void TestCustomEmptyException()
        {
            string compare = "Mood should not be empty";
            MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
            Assert.AreEqual(compare, moodAnalyser.AnalyzeMood());

        }
        [TestMethod]
        public void ClassReturnObject()
        {
            object compare = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProgram.MoodAnalyser", "MoodAnalyser");
            var compareType=compare.GetType();
            var objType=obj.GetType();
            Assert.AreEqual(compareType, objType);
        }
        [TestMethod]
        public void ImproperClassName()
        {
            
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProgram.Mood","MoodAnalyer");
            var compareType=expected.GetType();
            var objType = obj.GetType();
            //expected.Equals(obj);
            Assert.AreEqual(compareType,objType);
        }
        [TestMethod]
        public void ImproperConstructorName()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProgram.MoodAnalyser","Mood");
            var comparerType=expected.GetType();
            var objType = obj.GetType();
            //expected.Equals(obj);
            Assert.AreEqual(comparerType,objType);

        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Constructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.CreateMoodAnalyserParameterizedObject("MoodAnalyserProblem2.MoodAnalyser", "MoodAnalyser", message);

            }
            catch (CustomException ex)
            {
                throw new System.Exception(ex.Message);
            }
            actual.Equals(expected);
        }
       
        [TestMethod]
        public void Reflection_Return_Parameterized_Class_Invalid()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.CreateMoodAnalyserParameterizedObject("MoodAnalyserProblem2.MoodAna", "MoodAnalyser", message);

            }
            catch (CustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }


    }
}