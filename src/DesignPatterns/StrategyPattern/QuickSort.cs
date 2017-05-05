using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); //Quick sort is default behaviour of Sort()
            Console.WriteLine("Quick Sort is called");

        }
    }
}
