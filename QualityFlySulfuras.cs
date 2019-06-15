using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class QualityFlySulfuras : IQualityFly
    {
        int IQualityFly.UpdateQuality(int Quality, int SellIn)
        {/*•	El item "Sulfuras", nuestro articulo más legendario!, nunca debe venderse ni disminuye su calidad.*/
            return Quality;
        }
    }
}
