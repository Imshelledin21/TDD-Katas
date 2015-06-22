using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yahtzee.Tests {
    [TestClass]
    public class DiceRollerTests {

        [TestMethod]
        public void DiceRollShouldNotBeLessThan1() {
            //Arrange
            DiceRoller sut = new DiceRoller();

            //Act
            var result = sut.Roll();

            //Assert
            Assert.IsTrue(0 < result);
        }

        [TestMethod]
        public void DiceRollShouldNotBeGreaterThan6() {
            //Arrange
            DiceRoller sut = new DiceRoller();

            //Act
            var result = sut.Roll();

            //Assert
            Assert.IsTrue(7 > result);
        }

        [TestMethod]
        // What is the caveat to this test? How can we better test randomized results?
        public void DiceRollShouldBeRandom() {
            //Arrange
            DiceRoller sut = new DiceRoller();

            //Act
            var result1 = sut.Roll();
            var result2 = sut.Roll();
            var result3 = sut.Roll();
            var result4 = sut.Roll();

            //Assert
            Assert.IsTrue(result1 != result2 || result1 != result3 || result1 != result4 || result2 != result3 || result2 != result4 || result3 != result4);
        }
    }
}
