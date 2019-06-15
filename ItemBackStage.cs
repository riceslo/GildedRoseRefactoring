using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ItemBackStage: ItemGeneral
    {
         public ItemBackStage()
        {
            this.qualityFly = new QualityFlyBackStage();
            this.sellInFly = new SellInFly();

        }


    }
}
