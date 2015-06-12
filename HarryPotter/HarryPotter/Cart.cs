using System.Collections.Generic;

namespace HarryPotter {
    public class Cart {
        private PriceCalculator Calculator;

        public List<BookModel> Books { get; set; }
        public double TotalPrice { get; set; }

        public Cart(PriceCalculator calculator) {
            Calculator = calculator;

            Books = new List<BookModel>();
            TotalPrice = 0;
        }

        public void AddBook(BookModel book) {
            Books.Add(book);
        }

        public void AddBooks(List<BookModel> books) {
            Books.AddRange(books);
        }

        public void CalculatePrice() {
            TotalPrice = Calculator.CalculateTotalPrice(Books);
        }
    }
}
