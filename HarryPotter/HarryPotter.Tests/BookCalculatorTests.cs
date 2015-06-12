using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotter.Tests {
    [TestClass]
    public class BookCalculatorTests {

        private BookModel GetBook(string title) {
            return new BookModel() {
                Title = title,
                Price = 8
            };
        }

        [TestMethod]
        public void WhenOneBookInCart_CartTotalPriceShouldBe_8() {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            Cart cart = new Cart(calculator);
            BookModel book = GetBook("Chamber of Secrets");
            cart.AddBook(book);

            //Act
            cart.CalculatePrice();

            //Assert
            Assert.AreEqual(8, cart.TotalPrice);
        }

        [TestMethod]
        public void WhenTwoDifferentBooksInCart_CartTotalPriceShouldBe_15_2() {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            Cart cart = new Cart(calculator);
            List<BookModel> books = new List<BookModel>() {
                GetBook("Chamber of Secrets"),
                GetBook("Sorcerer's Stone")
            };
            cart.AddBooks(books);

            //Act
            cart.CalculatePrice();

            //Assert
            Assert.AreEqual(15.2, cart.TotalPrice);
        }

        [TestMethod]
        public void WhenThreeDifferentBooksInCart_CartTotalPriceShouldBe_21_6() {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            Cart cart = new Cart(calculator);
            List<BookModel> books = new List<BookModel>() {
                GetBook("Chamber of Secrets"),
                GetBook("Sorcerer's Stone"),
                GetBook("Goblet of Fire")
            };
            cart.AddBooks(books);

            //Act
            cart.CalculatePrice();

            //Assert
            Assert.AreEqual(21.6, cart.TotalPrice);
        }

        [TestMethod]
        public void WhenFourDifferentBooksInCart_CartTotalPriceShouldBe_25_6() {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            Cart cart = new Cart(calculator);
            List<BookModel> books = new List<BookModel>() {
                GetBook("Chamber of Secrets"),
                GetBook("Sorcerer's Stone"),
                GetBook("Goblet of Fire"),
                GetBook("Prisoner of Azkaban")
            };
            cart.AddBooks(books);

            //Act
            cart.CalculatePrice();

            //Assert
            Assert.AreEqual(25.6, cart.TotalPrice);
        }

        [TestMethod]
        public void WhenFiveDifferentBooksInCart_CartTotalPriceShouldBe_30() {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            Cart cart = new Cart(calculator);
            List<BookModel> books = new List<BookModel>() {
                GetBook("Philosopher's Stone"),
                GetBook("Chamber of Secrets"),
                GetBook("Sorcerer's Stone"),
                GetBook("Goblet of Fire"),
                GetBook("Prisoner of Azkaban")
            };
            cart.AddBooks(books);

            //Act
            cart.CalculatePrice();

            //Assert
            Assert.AreEqual(30, cart.TotalPrice);
        }
    }
}
