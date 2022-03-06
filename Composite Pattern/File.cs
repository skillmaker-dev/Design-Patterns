namespace Composite_Pattern
{
    public class File : Composant
    {
        public File(int size,string name)
        {
            Size = size;
            Name = name;
        }
        public override void ShowDetails()
        {
            System.Console.WriteLine("Name: {0} Size: {1}",Name,Size);
        }
        public override int GetSize()
        {
            return Size;
        }

        public override string GetName()
        {
            return Name;
        }
    }


}
