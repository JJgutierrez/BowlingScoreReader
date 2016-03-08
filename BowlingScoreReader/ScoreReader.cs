using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreReader
{
    class ScoreReader
    {
        string file = @"scorePlayer2.txt";
        FileReader reader =new  FileReader();
        FileWriter writer = new FileWriter();
        List<string> scoresSymbols = new List<string>();
        List<int> ScoreValues = new List<int>();
        char[] tempChar = new char[2];
        char[] frame10 = new char[2];

        string strike = "X";
        string SpareSymbol = "/";
        int strikeValue = 10;
        int spareValue = 10;
        public string[] Frames()
        {
            string[] frames = reader.Reader(file).Split(' ');
            return frames;
        }
        public string frame(string[] scores, int index)
        {
            string frameScore = scores[index];
            return frameScore;
        }
        public void ScoreListSymbols()
        {
            for(int i=0; i<=9; i++)
            {
                string score = frame(Frames(), i);
                scoresSymbols.Add(score);
                Console.WriteLine(score);
            }        
        }
        public void valueMaker()
        {  
            foreach(string score in scoresSymbols)
            {
                if (score == strike)
                {
                    ScoreValues.Add(strikeValue);    
                }
                else if (score.Contains(SpareSymbol))
                {
                    tempChar = score.ToCharArray();
                    ScoreValues.Add( spareValue + int.Parse(tempChar[0].ToString()));
                }
                else
                {
                    tempChar = score.ToCharArray();
                    ScoreValues.Add( int.Parse(tempChar[0].ToString()) + int.Parse(tempChar[1].ToString()));
                }      
            }
        } 
        
        public void ScoreRules()
        {
            int totalscore = 0;
            int nineFrames = 8;
            
            for(int i = 0; i<nineFrames; i++)
            {
                if (scoresSymbols[i] == strike)
                {
                    totalscore = totalscore+ ScoreValues[i] + ScoreValues[i + 1];
                }
                else if(scoresSymbols[i].Contains(SpareSymbol))
                {
                    string leftvalue = scoresSymbols[i+1].Remove(1);
                    int valueleft = int.Parse(leftvalue);
                    totalscore = totalscore + spareValue + valueleft;

                }
                else
                {
                    totalscore = totalscore + ScoreValues[i];

                }
            }
            Console.WriteLine("The Score is : {0}", totalscore + ScoreRules10Frame());
            writer.Writer(file,totalscore.ToString());

        }
        public int ScoreRules10Frame()
        {
            
            frame10 = scoresSymbols[9].ToCharArray();

            int score10Frame = 0;
            for (int i = 0; i < frame10.Count(); i ++)
            {
                if (frame10[i] == 'X')
                {
                    score10Frame = score10Frame + strikeValue;

                    return score10Frame;
                }
                else if (frame10[i] == '/')
                {
                    score10Frame = score10Frame + spareValue;
                }
                else
                {
                    score10Frame = score10Frame + int.Parse(frame10[i].ToString());
                    return score10Frame;
                }
            }
                return score10Frame;
          
        }
     
     
    }
}
