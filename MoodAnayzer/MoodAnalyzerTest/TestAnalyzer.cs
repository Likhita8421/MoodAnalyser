namespace MoodAnalyzerTest
{
    public class TestAnalyzer
    {
        [Test]
        public void GivenMoodSad_AnalyzeMood_ReturnSadMood()
        {
            string message = "I am in Sad mood";
            MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood(message);
            string actualResult = mood.getMood();
            Assert.That(actualResult, Is.EqualTo("Sad"));
        }
        [Test]
        public void GivenMoodAny_AnalyzeMood_ReturnHappyMood()
        {
            string message = "I am in Happy Mood";
            MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood(message);
            string actualResult = mood.getMood();
            Assert.That(actualResult, Is.EqualTo("Happy"));
        }
        [Test]
        public void GivenNull_AnalyzeMood_HandleNullException_ReturnNullMood()
        {
            try
            {
                string? message = null;
                MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood(message);
                string actualResult = mood.getMood();
            }
            catch (MoodAnayzer.AnalyzerException exc)
            {
                Assert.That(exc.Message, Is.EqualTo("Mood is null"));
            }
        }
        [Test]
        public void GivenEmpty_AnalyzeMood_HandleEmptyException_ReturnEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnayzer.AnalyzeMood mood = new MoodAnayzer.AnalyzeMood(message);
                string actualResult = mood.getMood();
            }
            catch (MoodAnayzer.AnalyzerException exc)
            {
                Assert.That(exc.Message, Is.EqualTo("Mood can not be Empty"));
            }
        }

    }
}