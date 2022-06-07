using System.Collections.Generic;

namespace ConsoleApp1
{
    class SortEnergyDesc : IComparer<AbstractClient>
    {
        public int Compare(AbstractClient x, AbstractClient y) => y.Energy - x.Energy;
    }
}
