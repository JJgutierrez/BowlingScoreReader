using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BowlingScoreReader
{
    class FileWriter
    {
        public void Writer(string path, string result)
        {
            File.AppendAllText(path,Environment.NewLine + result);
        }
    }
}
