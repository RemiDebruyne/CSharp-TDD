using ExerciceGradingCalculator.ClassBibliotheque;


namespace ExerciceGradingCalculator.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void WhenScore_95_Presence_90_Then_A()
        {
            //// Arrange 
            //var calcul = new Calcul();

            //// Act
            //var result = calcul.Addition(10, 30);

            //// Assert
            //Assert.Equal(40, result);

            // Arrange
            var calcul = new GradingCalculator()
            {
                Score = 95,
                AttendancePercentage = 90,
            };

            // Act
            var result = calcul.GetGrade();

            // Assert
            Assert.Equal('A', result);
        }
    }
}