using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter {
    public class DiscountModel {
        private Dictionary<int, double> Discount { get; set; }

        public DiscountModel() {
            Discount = new Dictionary<int, double>() {
                {1, 1},
                {2, .95},
                {3, .9},
                {4, .8},
                {5, .75}
            };
        }

        public double GetDiscount(int numberOfBooks) {
            if (numberOfBooks <= 1) numberOfBooks = 1;
            if (numberOfBooks >= 5) numberOfBooks = 5;

            return Discount[numberOfBooks];
        }
    }
}
