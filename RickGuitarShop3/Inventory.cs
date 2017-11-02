using System.Collections.Generic;

namespace RickGuitarShop3
{
    public class Inventory
    {
        private readonly List<Guitar> mGuitars = new List<Guitar>();

        public void Initialize()
        {
            AddGuitar( "V95693", 1499.95, 
                new GuitarSpec( GuitarSpec.Builders.Fender, GuitarSpec.Models.Accoustic, GuitarSpec.Woods.Alder, GuitarSpec.Woods.Alder ) );
            AddGuitar( "V95012", 1549.95, 
                new GuitarSpec( GuitarSpec.Builders.Fender, GuitarSpec.Models.Accoustic, GuitarSpec.Woods.Alder, GuitarSpec.Woods.Alder ) );
        }

        public void AddGuitar( string aSerialNumber, double aPrice, GuitarSpec aSpecification )
        {
            mGuitars.Add( new Guitar( aSerialNumber, aPrice, aSpecification ) );
        }

        public Guitar GetGuitar( string aSerialNumber )
        {
            foreach ( var guitar in mGuitars )
            {
                if ( guitar.SerialNumber == aSerialNumber ) return guitar;
            }
            return null;
        }

        public IEnumerable<Guitar> SearchGuitar( GuitarSpec aGuitarSpec )
        {
            var guitars = new List<Guitar>();
            foreach ( var guitar in mGuitars )
            {
                if ( aGuitarSpec.Builder  != GuitarSpec.Builders.Any && aGuitarSpec.Builder  != guitar.Specification.Builder  ) continue;
                if ( aGuitarSpec.Model    != GuitarSpec.Models.Any   && aGuitarSpec.Model    != guitar.Specification.Model    ) continue;
                if ( aGuitarSpec.BackWood != GuitarSpec.Woods.Any    && aGuitarSpec.BackWood != guitar.Specification.BackWood ) continue;
                if ( aGuitarSpec.TopWood  != GuitarSpec.Woods.Any    && aGuitarSpec.TopWood  != guitar.Specification.TopWood  ) continue;

                guitars.Add( guitar );
            }
            return guitars;
        }
    }
}
