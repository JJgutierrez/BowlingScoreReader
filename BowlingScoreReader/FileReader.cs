using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BowlingScoreReader
{
    class FileReader
    {
        public string Reader(string path)
        {
            string reader = File.ReadAllText(path);
            return reader;
        }
    }
}
