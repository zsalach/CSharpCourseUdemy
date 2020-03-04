using System;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            int iloscOcen = 0;
            Console.WriteLine("Wprowadzenie 11 kończy wprowadzanie ocen");
            
            for (; ; )
            {
               
                Console.WriteLine($"Podaj ocenę z zakresu 1-10.");
                double rating;
                bool result = double.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;
                }
                if (result)
                {
                    if (rating >= 1 && rating < 11)
                    {

                        diary.AddRating(rating);
                        iloscOcen++;
                    }
                }
                else
                {
                    Console.WriteLine($"Podana liczba jest poza zakresem ocen.");
                }
            }
            Console.WriteLine($"Masz {iloscOcen} ocen");
            Console.WriteLine($"średnia twoich ocen to {diary.CalculateAverage()}");
            Console.WriteLine($"Najwyższa ocena to: {diary.GiveMaxValue()}");
            Console.WriteLine($"Najniższa ocena to: {diary.GiveMinReting()}");
            Console.ReadKey();


           
            
            
        }

    }
}
