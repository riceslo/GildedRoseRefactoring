using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class QualityFlyConjured: IQualityFly

    {
        public int UpdateQuality(int Quality, int SellIn)
    {
        if (Quality > 50)
        { /*•	La calidad de un item nunca es mayor de 50.*/
            Quality = 50;
        }

        if (Quality > 0)
        {

            if (SellIn <= 0)
            { /*•	Cuando la fecha de venta a pasado, la calidad degrada al doble de velocidad.*/
                Quality -= 4;
            }
            else
            {/*•	Los items degradan la calidad en una unidad por cada actualización.*/
                Quality -= 2;
            }
        }

        if (Quality < 0)
        { /*•	La calidad de un item no es nunca negativa.*/
            Quality = 0;
        }

        return Quality;
    }
}

      
    
    
}
