using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotter.Tests {
    [TestClass]
    public class PriceCalculatorTests {

        [TestMethod]
        public void DiscountedPercentage_When2SameBooks_ShouldBe_1() {
            //Arrange
            List<BookModel> books = new List<BookModel>() {
                new BookModel() {Title = "Goblet of Fire"},
                new BookModel() {Title = "Goblet of Fire"}
            };
            PriceCalculator calculator = new PriceCalculator();
            double expectedResult = .95;

            //Act
            double actualResult = calculator.CalculateDiscountedPercentage(books.Count);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SeparateIdenticalBooks_When2Same1Different_ShouldBeTwoLists_IdenticalBooksInSeparateLists() {
            //Arrange
            List<BookModel> books = new List<BookModel>() {
                new BookModel() {Title = "Prisoner of Askaban"},
                new BookModel() {Title = "Goblet of Fire"},
                new BookModel() {Title = "Goblet of Fire"}
            };
            PriceCalculator calculator = new PriceCalculator();
            int expectedNumberOfLists = 2;

            //Act
            var bookLists = calculator.SeparateIdenticalBooks(books);

            //Assert
            Assert.AreEqual(expectedNumberOfLists, bookLists.Count);
            Assert.IsTrue(bookLists[0].Contains(bookLists[1].First()));
        }

        [TestMethod]
        public void CalculateTotalPrice_ShouldReturn_51_2() {
            //Arrange
            List<BookModel> books = new List<BookModel>() {
                new BookModel() {Title = "Prisoner of Askaban"},
                new BookModel() {Title = "Goblet of Fire"},
                new BookModel() {Title = "Goblet of Fire"},
                new BookModel() {Title = "Philosopher's Stone"},
                new BookModel() {Title = "Philosopher's Stone"},
                new BookModel() {Title = "Chamber of Secrets"},
                new BookModel() {Title = "Chamber of Secrets"},
                new BookModel() {Title = "Deathly Hallows"}
            };
            PriceCalculator calculator = new PriceCalculator();
            const double expectedResult = 51.2;

            //Act
            double result = calculator.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
