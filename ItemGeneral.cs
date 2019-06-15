using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
   public class ItemGeneral: Item
    {
        protected IQualityFly qualityFly;
        protected ISellInFly sellInFly;

        public ItemGeneral()
        {
            if (qualityFly is null) {   qualityFly = new QualityFly(); };
            if (sellInFly is null) { sellInFly = new SellInFly(); };

        }

        public void UpdateQuality() {
            this.Quality = qualityFly.UpdateQuality(this.Quality, this.SellIn);
            this.SellIn = sellInFly.UpdateSellIn(this.SellIn);
        }
    }
}
