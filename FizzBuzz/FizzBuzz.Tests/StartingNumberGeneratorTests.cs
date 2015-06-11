using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests {

    [TestClass]
    public class StartingNumberGeneratorTests {

        [TestMethod]
        public void StartingNumberShouldNotBeBelow1() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new StartingNumberGenerator(modulus);

            //Act
            var result = sut.GenerateNumber();

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void StartingNumberShouldNotBeAbove10() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new StartingNumberGenerator(modulus);

            //Act
            var result = sut.GenerateNumber();

            //Assert
            Assert.IsTrue(result < 10);
        }

        [TestMethod]
        public void StartingNumberShouldNotBeMultipleOf5() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new StartingNumberGenerator(modulus);

            //Act
            var result = sut.GenerateNumber();

            //Assert
            Assert.IsTrue(result % 5 != 0);
        }

        [TestMethod]
        public void StartingNumberShouldNotBeMultipleOf3() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new StartingNumberGenerator(modulus);

            //Act
            var result = sut.GenerateNumber();

            //Assert
            Assert.IsTrue(result % 3 != 0);
        }
    }
}
