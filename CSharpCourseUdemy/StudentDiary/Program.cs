using System;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {

            Diary diary = new Diary();
            diary.AddRating(5.1);
            diary.AddRating(5.7);
            diary.AddRating(5.3);
            diary.AddRating(5.9);

            DiaryStatistics stat = diary.ComputeStatistic();

            Console.WriteLine($"Średnia wartość: {stat.AverageGrade}");
            Console.WriteLine($"Maksymalna wartość: {stat.MaxGrade}" );


        }
    }
}
