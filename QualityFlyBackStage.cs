using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class QualityFlyBackStage : IQualityFly

    {
        int IQualityFly.UpdateQuality(int Quality, int SellIn)
        {/* •	los "backstage passes" incrementan su calidad conforme se aproxima la fecha de venta.           */
         /*     La calidad se incrementa por dos cuando quedan 10 días o menos para el concierto,               */
         /*     por 3 cuando quedan 5 días o menos. Sin embargo la calidad disminuye a 0 después del concierto. */
            if (SellIn <= 10)
            { /* La calidad se incrementa por dos cuando quedan 10 días o menos para el concierto,  */

                if (SellIn <= 5)
                {/* por 3 cuando quedan 5 días o menos.*/
                    if (SellIn <= 0)
                    { /* Sin embargo la calidad disminuye a 0 después del concierto. */
                        Quality = 0;
                    }
                    else
                    {
                        Quality += 3;
                    }
                }
                else
                {
                    Quality += 2;
                }

            }
            else {
                Quality += 1;
            }
            return Quality;
        }
    }
}
