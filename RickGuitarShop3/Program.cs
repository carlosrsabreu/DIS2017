using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop3
{
    class Program
    {
        static void Main( string[] args )
        {
            Inventory inventory = new Inventory();
            inventory.Initialize();

            Console.WriteLine( "Rick's Guitar Shop");
            Console.WriteLine();

            GuitarSpec wanted = new GuitarSpec( GuitarSpec.Builders.Fender, GuitarSpec.Models.Accoustic, GuitarSpec.Woods.Alder, GuitarSpec.Woods.Alder );

            var guitars = inventory.SearchGuitar( wanted );
            foreach ( var guitar in guitars )
            {
                GuitarSpec spec = guitar.Specification;
                Console.WriteLine( $"You might like this { spec.Builder } { spec.Model } guitar : { spec.BackWood } back and sides, { spec.TopWood } top." );
                Console.WriteLine( $"You can have it for only { guitar.Price } euros!");
                Console.WriteLine();
            }
            if ( ! guitars.Any() )
            {
                Console.WriteLine( "Sorry, we have nothing for you" );
            }
            Console.ReadKey();
        }
    }
}
