using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class SellinFlySulfuras : ISellInFly
    {
        int ISellInFly.UpdateSellIn(int SellIn)
        {
            return SellIn;
        }
    }
}
