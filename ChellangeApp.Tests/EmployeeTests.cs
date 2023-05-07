namespace ChellangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestAddingScoreForEmployee()
        {
            // Arrange
            var employee = new Employee("Natalia", "Nowak", 28);
            employee.AddScore(5);
            employee.AddScore(9);
            employee.AddScore(-10);
            employee.AddScore(6);

            // Act
            var result = employee.TotallScore;

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void TestSetEmployeeAge()
        {
            // Arrange
            var employee = new Employee("Natalia", "Nowak", 28);
            employee.SetAge(28);
            employee.SetAge(31);
            employee.SetAge(29);

            // Act
            var result = employee.Wiek;

            // Assert
            Assert.AreEqual(29, result);
        }
    }
}