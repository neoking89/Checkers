using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers;

internal class Move
{
    public (int, int) From { get; set; }
    public (int, int) To { get; set; }
    public Move((int, int) from, (int, int) to)
    {
        From = from;
        To = to;
    }

}
