namespace Builder_Pattern
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house;
        public HouseBuilder()
        {
            _house = new House();
        }
        public IHouseBuilder BuildBase(string houseBase)
        {
            _house.Base = houseBase;
            return this;
        }

        public IHouseBuilder BuildPillars(string housePillars)
        {
            _house.Pillars = housePillars;
            return this;
        }

        public IHouseBuilder BuildRoof(string houseRoof)
        {
            _house.Roof = houseRoof;
            return this;
        }

        public IHouseBuilder BuildWalls(string houseWalls)
        {
            _house.Walls = houseWalls;
            return this;
        }

        public House GetHouse()
        {
            var house = _house;
            _house = new House();
            return house;
        }
    }
}
