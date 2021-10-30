using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodPrgrm;

namespace MoodPrgMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysis_Exception_Indicating_EmptyMood()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }

        }
        //TC 3.2 Given Empty Mood Should Throw InvalidMoodException indicating empty
        //Given-When-Then
        [TestMethod]
        public void Empty_Mood_Should_Throw_MoodAnalysis_Exception_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }

        }
    }
}






    
