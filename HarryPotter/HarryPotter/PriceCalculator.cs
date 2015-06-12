using System.Collections.Generic;
using System.Linq;

namespace HarryPotter {
    public class PriceCalculator {
        private readonly DiscountModel Discounter;

        public PriceCalculator() {
            Discounter = new DiscountModel();
        }

        public double CalculateTotalPrice(List<BookModel> books) {
            List<List<BookModel>> bookLists = SeparateIdenticalBooks(books);

            return (from bookList
                    in bookLists let groupPrice = 8*bookList.Count
                    select groupPrice*CalculateDiscountedPercentage(bookList.Count))
                    .Aggregate<double, double>(0, (current, groupPrice) => current + groupPrice);
        }

        public double CalculateDiscountedPercentage(int bookCount) {
            return Discounter.GetDiscount(bookCount);
        }

        public List<List<BookModel>> SeparateIdenticalBooks(List<BookModel> books) {
            List<List<BookModel>> bookLists = new List<List<BookModel>>();

            while (books.Any()) {
                List<BookModel> bookList = books.Distinct().ToList();

                foreach (var book in bookList) {
                    books.Remove(book);
                }

                bookLists.Add(bookList);
            }

            return bookLists;
        }
    }
}
