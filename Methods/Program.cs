using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[3] { "Inception" , "Taken 1", "Rain Man"};

            List<int> ranks = new List<int>();

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("Please insert your rank (1-10) to the movies : " + movies[i] + ":");
                int rank = Convert.ToInt32(Console.ReadLine());
                ranks.Add(rank);
               
            }

            double avarage = RankAverage(ranks);
            Console.WriteLine($"Average of rank is : { avarage}");
            Console.ReadKey(true);

        }

        public static double RankAverage(List<int> userRank)
        {
            int sum = 0;
            for (int i = 0; i < userRank.Count; i++)
            {
                
                sum += userRank[i];
                
            }
            double avg = sum / userRank.Count;
            return avg;



        }
    }
}
