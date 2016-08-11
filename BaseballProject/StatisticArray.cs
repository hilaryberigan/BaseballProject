using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballProject
{
    class StatisticArray
    {
        double[] statistics = new double[8];

        public void AddArray()
        {
            statistics[0] = .325;
            statistics[1] = 19;
            statistics[2] = 58;
            statistics[3] = 115;
            statistics[4] = 13;
            statistics[5] = 93;
            statistics[6] = 354;
            statistics[7] = 192;
        }
        public double CalculateSluggingPercentage()
        {
            double atBats = statistics[6];
            double totalBases = statistics[7];
            double sluggingPercentage = totalBases / atBats;
            return sluggingPercentage;
            }

        }

    }
      


