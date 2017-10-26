using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop1
{
    class Program
    {
        static void Main( string[] args )
        {
            Inventory inventory = new Inventory();
            inventory.Initialize();

            Console.WriteLine( "Rick's Guitar Shop");
            Console.WriteLine();

            Guitar wanted = new Guitar( "", 0, "fender", "Stratocastor", "Alder", "Alder" );

            Guitar guitar = inventory.SearchGuitar( wanted );
            if ( guitar != null )
            {
                Console.WriteLine( $"You might like this { guitar.Builder } { guitar.Model } guitar : { guitar.BackWood } back and sides, { guitar.TopWood } top." );
                Console.WriteLine( $"You can have it for only { guitar.Price } euros!");
            }
            else
            {
                Console.WriteLine( "Sorry, we have nothing for you" );
            }
            Console.ReadKey();
        }
    }
}
