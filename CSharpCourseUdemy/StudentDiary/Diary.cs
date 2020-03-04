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

 
        List<double> ratings = new List<double>(); // listy przechowywane są w liście


        internal DiaryStatistics ComputeStatistic()
        {
            DiaryStatistics stats = new DiaryStatistics();

            double sum = 0;
            double avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade =   ratings.Max();
            stats.MinGrade = ratings.Min();
            return stats;

        }

    
        /// <summary>
        /// Dodawanie oceny. 
        /// </summary>
        /// <param name="rating"></param>
        
        public void AddRating(double rating)
        {
            ratings.Add(rating);
        }
    }
}