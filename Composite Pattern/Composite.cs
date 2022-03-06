namespace Composite_Pattern
{

    abstract public class Composant
    {
        public int Size { get; set; }
        public string Name { get; set; }

        abstract public void ShowDetails();
        abstract public int GetSize();
        abstract public string GetName();

    }


}
