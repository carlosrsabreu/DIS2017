using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop3
{
    public class GuitarSpec
    {
        public enum Builders { Fender, Martin, Gibson, Collings, Olson, Ryan, PRS, Any };
        public enum Woods { IndianRosewood, BrazilianRoseWooed, Mahogany, Maple, Cocobolo, Cedar, Adirondack, Alder, Sirka, Any };

        public enum Models { Accoustic, Electric, Any };

        public GuitarSpec( Builders aBuilder, Models aModel, Woods aBackWood, Woods aTopWood )
        {
            Builder = aBuilder;
            Model = aModel;
            BackWood = aBackWood;
            TopWood = aTopWood;
        }

        public Builders Builder { get; }
        public Models Model { get; }
        public Woods BackWood { get; }
        public Woods TopWood { get; }
    }

}
