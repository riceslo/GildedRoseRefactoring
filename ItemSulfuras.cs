using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ItemSulfuras : ItemGeneral
    {


        public ItemSulfuras()
        {
            this.qualityFly = new QualityFlySulfuras();
            this.sellInFly = new SellinFlySulfuras();

        }
    }
}
