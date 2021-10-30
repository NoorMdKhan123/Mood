using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodPrgrm;

namespace MoodPrgMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null)]
        public void MoodAnalyserTest(string message)
        {
            //Arrange
            string except = "HAPPY";

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            var mood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(except, mood);




        }
    }

}
