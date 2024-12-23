using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyProject
{
    public interface ISortStrategy
    {
        void Sort(List<int> list);
    }
}
