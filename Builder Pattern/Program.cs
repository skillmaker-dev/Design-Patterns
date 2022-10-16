namespace Builder_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We instiate our builder
            IHouseBuilder builder = new HouseBuilder();
            //Then we instiate our director who tells the builder what to do.
            IHouseBuilderDirector director = new HouseBuilderDirector(builder);
            director.Construct();

            //Finally we get our finished house!
            var house = builder.GetHouse();
        }
    }
}