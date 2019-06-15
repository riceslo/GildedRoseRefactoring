using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class QualityFlyAgedBrie :  IQualityFly
    {
        int IQualityFly.UpdateQuality(int Quality, int SellIn)
        {

            if (Quality < 0)
            { /*•	La calidad de un item no es nunca negativa.*/
                Quality = 0;
            }


            if (Quality < 50)
            {/*•	El item "aged brie" incrementa su calidad en lugar de decrementarla según pasan los días.*/
                Quality += 1;
                 
            }

            if (Quality > 50)
            { /*•	La calidad de un item nunca es mayor de 50.*/
                Quality = 50;
            }
            return Quality;
        }
    }
}
