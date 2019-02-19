using System;

namespace ConsoleAppIntToRomanTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello Actibase !");
            Random r = new Random(0);
            Console.WriteLine("0 = " + IntToRomanian(0));
            for (int i = 0; i < 1000; i++) {
                var test = r.Next(9999);
                Console.WriteLine(test + " = " + IntToRomanian(test));
            }
            Console.ReadKey();
        }

        // -------- 45 min pour comprendre les chiffres romains sur internet, codé en moins de 10 mn ensuite, fait pour la lisibilité -------- //
        // -------- Source pour comprendre les chiffres romains : https://www.dcode.fr/chiffres-romains

        static string[] _units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        static string[] _tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        static string[] _hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

        static String IntToRomanian(int n) {
            if (n < 0 || n > 9999)
                throw new ArgumentException("Parameter must be in between 0 and 9999");
            return new string('M', n / 1000) + (_hundreds[n / 100 % 10] + _tens[n / 10 % 10] + _units[n % 10]);
        }
    }
}
