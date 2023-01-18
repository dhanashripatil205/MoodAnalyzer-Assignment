using ModeAnalyzerAssignment;
//using MoodAnalyzer;
using System.Diagnostics.SymbolStore;

namespace TestCaseMoodAnalyzer
{
   
 [TestClass]
    public class UnitTest1
    {
          [TestMethod]
        public void UseCase4_2()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.Mood", "Mood");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Class not found", Exception.Message);
            }
        }
    }
}
