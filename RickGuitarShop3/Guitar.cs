using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop3
{
    public class Guitar
    {
        public Guitar( string aSerialNumber, double aPrice, GuitarSpec aSpecification  )
        {
            SerialNumber = aSerialNumber;
            Price = aPrice;
            Specification = aSpecification;
        }

        public string SerialNumber { get; }
        public double Price { get; set; }
        public GuitarSpec Specification { get; }
    }

}
