using System;

namespace FizzBuzz {
    public class FizzBuzzConverter {
        private ModulusCalculator Modulus { get; set; }

        public FizzBuzzConverter(ModulusCalculator modulus) {
            Modulus = modulus;
        }

        public string Transform(int number) {
            string output = String.Empty;

            if (Modulus.IsModulusOfThree(number)) {
                output += "Fizz";
            }
            if (Modulus.IsModulusOfFive(number)) {
                output += "Buzz";
            }
            if (String.IsNullOrEmpty(output)) {
                output = number.ToString();
            }

            return output;
        }
    }
}
