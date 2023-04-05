namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScore_SchouldCorrectResult()
        {
            //arrange
            var em1 = new Employee("Adam", "Adamczyk", 20);
            em1.AddScore(5);
            em1.AddScore(5);
            em1.AddScore(5);
            em1.AddScore(0);
            em1.AddScore(-20);


            //act
            var result = em1.Result;

            //assert
            Assert.AreEqual(-5, result);

        }
    }
}