using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests {
    [TestClass]
    public class ModulusCalculatorTests {

        [TestMethod]
        public void CalculateModulusOfThree_When0_ReturnsTrue() {
            //Arrange
            var sut = new ModulusCalculator();

            //Act
            var result = sut.IsMultipleOfThree(3);

            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CalculateModulusOfThree_WhenNot0_ReturnsFalse() {
            //Arrange
            var sut = new ModulusCalculator();

            //Act
            var result = sut.IsMultipleOfThree(2);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CalculateModulusOfFive_When0_ReturnsTrue() {
            //Arrange
            var sut = new ModulusCalculator();

            //Act
            var result = sut.IsMultipleOfFive(5);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CalculateModulusOfFive_WhenNot0_ReturnsFalse() {
            //Arrange
            var sut = new ModulusCalculator();

            //Act
            var result = sut.IsMultipleOfFive(4);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
