namespace Abstract_Factory
{
    public class LenovoFactory : ILaptopFactory
    {
        public ILaptop CreateLaptop(string type)
        {
            if (type == "ThinkPad")
                return new ThinkPadLaptop();
            else if (type == "IdeaPad")
                return new IdeaPadLaptop();

            return null;
       
        }
    }

}
