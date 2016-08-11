using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StatisticArray statisticArray = new StatisticArray();
            statisticArray.AddArray();
            Console.WriteLine("Ryan Braun's Slugging Percentage: \t" + statisticArray.CalculateSluggingPercentage());
            Console.ReadLine();
        }      
    }
}
