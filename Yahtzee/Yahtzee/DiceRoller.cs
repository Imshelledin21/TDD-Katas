using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee {
    public class DiceRoller {
        public int Roll() {
            Random rand = new Random();
            return rand.Next(1, 6);
        }
    }
}
