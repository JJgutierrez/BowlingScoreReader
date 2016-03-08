using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreReader
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string scorePlayer2 = @""; 
            ScoreReader sc = new ScoreReader();
            sc.ScoreListSymbols();
            sc.valueMaker();      
            sc.ScoreRules();

        }
    }
}
