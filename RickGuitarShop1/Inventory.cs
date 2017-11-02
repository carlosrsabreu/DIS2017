using System.Collections.Generic;

namespace RickGuitarShop1
{
    public class Inventory
    {
        private readonly List<Guitar> mGuitars = new List<Guitar>();

        public void Initialize()
        {
            AddGuitar( "V95693", 1499.95, "Fender", "Stratocastor", "Alder", "Alder" );
        }

        public void AddGuitar( string aSerialNumber, double aPrice,
            string aBuilder, string aModel, string aBackWood, string aTopWood )
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
                if ( ! string.IsNullOrEmpty( aGuitar.Builder  ) && aGuitar.Builder  != guitar.Builder  ) continue;
                if ( ! string.IsNullOrEmpty( aGuitar.Model    ) && aGuitar.Model    != guitar.Model    ) continue;
                if ( ! string.IsNullOrEmpty( aGuitar.BackWood ) && aGuitar.BackWood != guitar.BackWood ) continue;
                if ( ! string.IsNullOrEmpty( aGuitar.TopWood  ) && aGuitar.TopWood  != guitar.TopWood  ) continue;

                return guitar;
            }
            return null;
        }
    }
}
