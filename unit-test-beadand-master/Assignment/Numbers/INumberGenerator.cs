using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Numbers
{
    public interface INumberGenerator
    {
        int GenerateEven(int limit);

        int GenerateOdd(int limit);
    }
}
