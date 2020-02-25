
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Greeting();
                AgeMethod();
                Setting();
            }
        }

        private static void Setting()
        {
            Console.ReadKey(true);
            Console.Clear(); // czyści ekran.
            Console.ResetColor(); //resetuje kolor
        }

        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię. ");
            string name;
            name = Console.ReadLine().Trim();
            string pierwszaLitera = name.Substring(0, 1);
            string reszta = name.Substring(1); //nazwy substring możemu użyć w dwóch wariantach.
            name = pierwszaLitera.ToUpper() + reszta.ToLower(); // łączymy te dwa stringi
            Console.WriteLine($"Witaj {name}.");
        }

        private static void AgeMethod()
        {
            Console.Write("Wpisz ile masz lat. ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            // jezeli u zytkownik poda wiek  w postaci cyfry instrukcja ta przekaże wiek do zmiennej age.
            // jeżeli użytkownik wprowadzi litery zostanie ustawione false i konwersja się nie dokona.

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jestes pełnoletni");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś neipoprawny wiek");
            }
            else
            {
                Console.WriteLine("Możemy ci zaoferować mleko");
            }
        }
    }
}
