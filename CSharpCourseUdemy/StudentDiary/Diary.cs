using System;

using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // stan (zmienne - pola)

        List<float>ratings = new List<float>();


        //zachowania
        public void AddRating(float rating) // metoda ma dodawać oceny di naszej listy.
        {
            ratings.Add(rating);
        }
        public float CalculateAverage()
        {
            float sum = 0;
            float avg = 0;

            foreach(var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();

            return avg;
        }



        // metoda do pobierania maksymalnej oceny..
        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GivrMinRating()
        {
            return ratings.Min();
        }
    }
}
