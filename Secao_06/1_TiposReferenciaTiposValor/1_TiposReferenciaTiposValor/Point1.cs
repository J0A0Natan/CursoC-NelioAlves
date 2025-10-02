using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TiposReferenciaTiposValor
{
    public struct Point1
    {
        public double x, y;

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
