using System;

namespace HarryPotter {
    public class BookModel : IEquatable<BookModel> {
        public string Title { get; set; }
        public double Price { get; set; }

        public BookModel() {
            Price = 8;
        }

        public bool Equals(BookModel other) {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;

            return Title.Equals(other.Title) && Price.Equals(other.Price);
        }

        public override int GetHashCode() {
            int hashTitleName = Title == null ? 0 : Title.GetHashCode();
            int hashPrice = Price.GetHashCode();

            return hashTitleName ^ hashPrice;
        }
    }
}
