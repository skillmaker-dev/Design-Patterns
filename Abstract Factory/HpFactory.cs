namespace Abstract_Factory
{
    public class HpFactory : ILaptopFactory
    {
        public ILaptop CreateLaptop(string type)
        {
            if (type == "EliteBook")
                return new EliteBookLaptop();
            else if (type == "ProBook")
                return new ProBookLaptop();

            return null;

        }
    }

}
