namespace RickGuitarShop2
{
    public class Guitar
    {
        public enum Builders { Fender, Martin, Gibson, Collings, Olson, Ryan, PRS, Any };
        public enum Woods { IndianRosewood, BrazilianRoseWooed, Mahogany, Maple, Cocobolo, Cedar, Adirondack, Alder, Sirka, Any };

        public enum Models { Accoustic, Electric, Any };

        public Guitar( string aSerialNumber, double aPrice, 
            Builders aBuilder, Models aModel, Woods aBackWood, Woods aTopWood )
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
        public Builders Builder { get; }
        public Models Model { get; }
        public Woods BackWood { get; }
        public Woods TopWood { get; }
    }

}
