using System;

using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
{
    class Diary
    {


        public Diary()
        {
            ratings = new List<double>();
        }


        //stan
        List<double> ratings = new List<double>(); // listy przechowywane są w liście



        //zachowania
//1. dodajemy oceny do listy.
        /// <summary>
        /// Pobieramy najwyższą ocenę.
        /// </summary>
        /// <returns></returns>
        /// <param name="rating">nowa ocena</param>
        public void AddRating(double rating)
        {
            ratings.Add(rating);
        }
 // 2. wyliczamy średnią.

        /// <summary>
        /// Metoda oblicz średnią ocen.
        /// </summary>
        /// <returns></returns>
        public double CalculateAverage()
        {
            double sum = 0;
            double avg = 0;
            foreach(var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();//count zlicza ilośc elementów
            return avg;                 //metoda zwraca średnią.
        }
// 3.  metoda do zwracania maksymalnej oceny.
        
        public double GiveMaxValue()
        {
            return ratings.Max();
        }

  
        public double GiveMinReting()
        {
            return ratings.Min();
        }
    }
}
