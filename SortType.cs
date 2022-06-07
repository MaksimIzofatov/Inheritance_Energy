using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortType : IComparer<AbstractClient>
    {
        public int Compare(AbstractClient x, AbstractClient y) => x.TypeNumber.CompareTo(y.TypeNumber);
    }
}
