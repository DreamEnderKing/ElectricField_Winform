using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationBase
{
    struct Scalar
    {
        public Scalar(double d) => val = d;
        private double val;
        public static implicit operator double(Scalar s) => s.val;
        public static implicit operator float(Scalar s) => (float)s.val;
        public static implicit operator Scalar(double d) => new Scalar(d);
    }
}
