namespace ChellengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void CheckTwoFloatIsEqaul()
        {
            // Arrange
            float number1 = 134.45E-2f;
            float number2 = 134.45E-2f;

            // Act

            // Assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CheckTwoIntegerIsEqual()
        {
            // Arrange
            int Age1 = 39;
            int Age2 = 39;
            // Act

            // Assert
            Assert.AreEqual(Age1, Age2);
        }

        [Test]
        public void GetUserNameShouldReturnTheSameValue()
        {
            // Arrange
            var employee1 = GetEmployee("Adam", "Nowak", 39);
            var employee2 = GetEmployee("Adam", "Nowak", 39);
            // Act

            // Assert
            Assert.AreEqual(employee1.Imie, employee2.Imie);
        }

        [Test]
        public void GetUserSohuldReturnDifferentObject()
        {
            // Arrange
            var employee1 = GetEmployee("Adam", "Nowak", 39);
            var employee2 = GetEmployee("Adam", "Nowak", 39);
            // Act

            // Assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
