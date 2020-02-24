using System;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
           
/*          diary.AddRating(5);
            diary.AddRating(8.5f);       
            diary.AddRating(8.7f);
            float avg = diary.CalculateAverage();
            float max = diary.GiveMaxRating();
            float min = diary.GivrMinRating();
*/

            for(; ; ) //nieskończona pętla!!!
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");
                float rating; 
                bool result = float.TryParse(Console.ReadLine(), out rating); 
                // sprawdza czy wprowadzony znak list liczbą
                
                if(rating == 11)    // program jes zakończany po wpisaniu liczby 11
                {
                    break;
                }

                if(result = true) // jeżeli liczba to
                {
                    if (rating > 0 && rating <=10) // sprawdzamy czy jest z przedziału 1-10
                    {
                        diary.AddRating(rating); // jeżeli z przedziału to dodajemy.
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba");
                    }
                }
            } 
            // po zakończeniu pętli wyświetla dane.
            Console.WriteLine($"Srednia twoich ocen to: {diary.CalculateAverage()}");
            Console.WriteLine("Najwyższa oczena to: {0}",diary.GiveMaxRating());
            Console.WriteLine($"Najniższa ocena to: {diary.GivrMinRating()}");
            Console.WriteLine();
        }
    }
}
