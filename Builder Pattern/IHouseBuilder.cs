namespace Builder_Pattern
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildBase(string houseBase);
        IHouseBuilder BuildPillars(string housePillars);
        IHouseBuilder BuildRoof(string houseRoof);
        IHouseBuilder BuildWalls(string houseWalls);
        House GetHouse();
    }
}
