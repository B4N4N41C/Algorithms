using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class Context
    {
        public IStrategy Strategy { get; set; }
        public int[] Request(int[] array)
        {
            return Strategy.Sort(array);
        }
    }
}
