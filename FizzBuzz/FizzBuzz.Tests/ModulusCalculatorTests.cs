using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests {
    [TestClass]
    public class ModulusCalculatorTests {

        [TestMethod]
        public void CalculateModulusOfThree_When0_ReturnsTrue() {
            var sut = new ModulusCalculator();

            var result = sut.IsModulusOfThree(3);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CalculateModulusOfThree_WhenNot0_ReturnsFalse() {
            var sut = new ModulusCalculator();

            var result = sut.IsModulusOfThree(2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CalculateModulusOfFive_When0_ReturnsTrue() {
            var sut = new ModulusCalculator();

            var result = sut.IsModulusOfFive(5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CalculateModulusOfFive_WhenNot0_ReturnsFalse() {
            var sut = new ModulusCalculator();

            var result = sut.IsModulusOfFive(4);

            Assert.IsFalse(result);
        }
    }
}
