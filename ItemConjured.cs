using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ItemConjured : ItemGeneral
    {


        public ItemConjured()
        {
            this.qualityFly = new QualityFlyConjured();
            this.sellInFly = new SellInFly();

        }
    }
}