namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComparisonValueTypesDouble()
        {
            //arrange
            double number5 = 9.99999;
            double number6 = 9.99991;

            //act


            //assert
            Assert.AreNotEqual(number5, number6);

        }

        [Test]
        public void ComparisonValueTypesFloat()
        {
            //arrange
            float number3 = 4.4f;
            float number4 = 4.4f;

            //act


            //assert
            Assert.AreEqual(number3, number4);

        }

        [Test]
        public void ComparisonValueTypesInt()
        {
            //arrange
            int number1 = 573;
            int number2 = 573;

            //act


            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void ComparisonString()
        {
            //arrange
            string text1 = "CSharp";
            string text2 = "CSharp";
            string text3 = "CSharp";

            //act


            //assert
            Assert.AreEqual(text1, text2, text3);

        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            //arrange
            var em1 = GetEmployee("Adam", "Adamczyk", 20);
            var em2 = GetEmployee("Adam", "Adamczyk", 20);

            //act


            //assert
            Assert.AreNotEqual(em1, em2);

        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
