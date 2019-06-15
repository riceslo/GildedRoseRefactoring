using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class SellInFly : ISellInFly

    {
        public int UpdateSellIn(int SellIn)
        {
            return SellIn -= 1;
        }
    }
}
