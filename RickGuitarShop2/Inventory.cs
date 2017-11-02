using System.Collections.Generic;

namespace RickGuitarShop2
{
    public class Inventory
    {
        private readonly List<Guitar> mGuitars = new List<Guitar>();

        public void Initialize()
        {
            AddGuitar( "V95693", 1499.95, Guitar.Builders.Fender, Guitar.Models.Accoustic, Guitar.Woods.Alder, Guitar.Woods.Alder );
            AddGuitar( "V95012", 1549.95, Guitar.Builders.Fender, Guitar.Models.Accoustic, Guitar.Woods.Alder, Guitar.Woods.Alder );
        }

        public void AddGuitar( string aSerialNumber, double aPrice,
            Guitar.Builders aBuilder, Guitar.Models aModel, Guitar.Woods aBackWood, Guitar.Woods aTopWood )
        {
            mGuitars.Add( new Guitar( aSerialNumber, aPrice, aBuilder, aModel, aBackWood, aTopWood ) );
        }

        public Guitar GetGuitar( string aSerialNumber )
        {
            foreach ( var guitar in mGuitars )
            {
                if ( guitar.SerialNumber == aSerialNumber ) return guitar;
            }
            return null;
        }

        public Guitar SearchGuitar( Guitar aGuitar )
        {
            foreach ( var guitar in mGuitars )
            {
                if ( aGuitar.Builder  != Guitar.Builders.Any && aGuitar.Builder  != guitar.Builder  ) continue;
                if ( aGuitar.Model    != Guitar.Models.Any   && aGuitar.Model    != guitar.Model    ) continue;
                if ( aGuitar.BackWood != Guitar.Woods.Any    && aGuitar.BackWood != guitar.BackWood ) continue;
                if ( aGuitar.TopWood  != Guitar.Woods.Any    && aGuitar.TopWood  != guitar.TopWood  ) continue;

                return guitar;
            }
            return null;
        }
    }
}
