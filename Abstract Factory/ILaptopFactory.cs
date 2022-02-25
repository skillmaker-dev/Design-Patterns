namespace Abstract_Factory
{
    public interface ILaptopFactory
    {
        ILaptop CreateLaptop(string type);
    }

}
