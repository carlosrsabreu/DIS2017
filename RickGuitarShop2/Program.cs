using System;

namespace RickGuitarShop2
{
    class Program
    {
        static void Main( string[] args )
        {
            Inventory inventory = new Inventory();
            inventory.Initialize();

            Console.WriteLine( "Rick's Guitar Shop");
            Console.WriteLine();

            Guitar wanted = new Guitar( "", 0, Guitar.Builders.Fender, Guitar.Models.Accoustic, Guitar.Woods.Alder, Guitar.Woods.Alder );

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
