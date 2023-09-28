using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public interface IStrategy
    {
        int[] Sort(int[] array);
        ulong OutComparisonCount();
        ulong OutReplacementCount();
    }
}
