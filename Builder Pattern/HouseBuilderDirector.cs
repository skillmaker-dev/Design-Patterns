namespace Builder_Pattern
{
    public class HouseBuilderDirector : IHouseBuilderDirector
    {
        private readonly IHouseBuilder _houseBuilder;

        public HouseBuilderDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void Construct()
        {
            _houseBuilder.BuildBase("base")
                        .BuildPillars("pillars")
                        .BuildWalls("walls")
                        .BuildRoof("roof");
        }
    }
}
