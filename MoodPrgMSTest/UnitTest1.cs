using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodPrgrm;

namespace MoodPrgMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyserTest()
        {
            //Arrange
            string except = "HAPPY";
            string message = "I am in Any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            var mood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(except, mood);


        }
        [TestMethod]
        public void MoodAnalyserTest1()
        {
            //Arrange
            string except = "SAD";
            string message = "I am in Sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            

            //Act
            var mood = moodAnalyser.AnalyseMood(message);

            //Assert
            Assert.AreEqual(except, mood);


        }
    }

}
