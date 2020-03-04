using System;
using System.Collections.Generic;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);

            Diary diary2 = diary;
            diary2.AddRating(8);
            diary.AddRating(3);

            List<int> lista = new List<int>();
           
        }
    }
}
