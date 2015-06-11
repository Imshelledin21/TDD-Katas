using System;

namespace FizzBuzz {
    public class Program {
        static void Main(string[] args) {
            var modulus = new ModulusCalculator();
            var startingNumberGenerator = new StartingNumberGenerator(modulus);

            int startingNumber = startingNumberGenerator.GenerateNumber();

            var converter = new FizzBuzzConverter(modulus);

            for (int i = startingNumber; i <= startingNumber + 1000; i++) {
                Console.WriteLine(converter.Transform(i));
            }

            Console.ReadLine();
        }
    }
}
