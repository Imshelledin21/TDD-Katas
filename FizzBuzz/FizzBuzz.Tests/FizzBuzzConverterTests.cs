using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests {
    [TestClass]
    public class FizzBuzzConverterTests {

        [TestMethod]
        public void WhenMultipleOf3_OutputFizz() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new FizzBuzzConverter(modulus);
            const int number = 3;

            //Act
            string output = sut.Transform(number);

            //Assert
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void WhenMultipleOf5_OutputBuzz() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new FizzBuzzConverter(modulus);
            const int number = 5;

            //Act
            string output = sut.Transform(number);

            //Assert
            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        public void WhenMultipleOf3And5_OutputFizzBuzz() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new FizzBuzzConverter(modulus);
            const int number = 15;

            //Act
            string output = sut.Transform(number);

            //Assert
            Assert.AreEqual("FizzBuzz", output);
        }

        [TestMethod]
        public void WhenNotMultipleOf5Or3_OutputGivenNumberAsString() {
            //Arrange
            var modulus = new ModulusCalculator();
            var sut = new FizzBuzzConverter(modulus);
            const int number = 11;

            //Act
            string output = sut.Transform(number);

            //Assert
            Assert.AreEqual("11", output);
        }
    }
}
