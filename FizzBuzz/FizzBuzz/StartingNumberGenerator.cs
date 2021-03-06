﻿using System;

namespace FizzBuzz {
    public class StartingNumberGenerator {
        private readonly ModulusCalculator Modulus;

        public StartingNumberGenerator(ModulusCalculator modCalc) {
            Modulus = modCalc;
        }

        public int GenerateNumber() {
            int number;
            do {
                number = GenerateRandomNumber();
            } while (Modulus.IsMultipleOfFive(number) || Modulus.IsMultipleOfThree(number));
            return number;
        }

        private static int GenerateRandomNumber() {
            Random rand = new Random();
            return rand.Next(1, 9);
        }

    }
}
