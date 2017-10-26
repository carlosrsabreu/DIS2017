using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop1
{
    public class Guitar
    {
        public Guitar( string aSerialNumber, double aPrice, 
            string aBuilder, string aModel, string aBackWood, string aTopWood )
        {
            SerialNumber = aSerialNumber;
            Price = aPrice;
            Builder = aBuilder;
            Model = aModel;
            BackWood = aBackWood;
            TopWood = aTopWood;
        }

        public string SerialNumber { get; }
        public double Price { get; set; }
        public string Builder { get; }
        public string Model { get; }
        public string BackWood { get; }
        public string TopWood { get; }
    }

}
