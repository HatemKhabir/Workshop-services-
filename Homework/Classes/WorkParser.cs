using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQXBY9.Classes
{
    internal class WorkParser
    {
        public Work Parse(string[] seperatedLine)
        {
            return new Work(seperatedLine[0], seperatedLine[1], seperatedLine[2]);

        }
    }
}
