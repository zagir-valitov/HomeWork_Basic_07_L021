using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Fibonachi
    {        
        public static long RecursiveMethod(long Number)
        {
            //if (Number == 0 || Number == 1)
            //{
            //    return Number;
            //}
            return Number > 1 ? RecursiveMethod(Number - 1) + RecursiveMethod(Number - 2) : Number;
        }


        
        public static long CyclicMethod(long Numbern)
        {
            long _base1 = 0;
            long _base2 = 1;
            long _temp;
            for (long i = 0; i < Numbern; i++)
            {
                _temp = _base1;
                _base1 = _base2;
                _base2 += _temp;
            }
            return _base1;
        }
    }
}
