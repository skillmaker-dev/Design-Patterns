using System.Collections.Generic;
using System.Linq;

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

    public class Folder : Composant
    {
        private List<Composant> Components = new List<Composant>();
        public Folder(string name)
        {
            this.Name = name;
        }
        public void AddComponent(Composant component)
        {
            Components.Add(component);
        }


        public override void ShowDetails()
        {
            System.Console.WriteLine("FOLDER NAME: {0} TOTAL SIZE: {1}",Name,Components.Sum(f => f.GetSize()));
            foreach(var component in Components)
            {
                component.ShowDetails();
            }           
        }

        public override int GetSize()
        {
            return Components.Sum(c => c.GetSize());
        }

        public override string GetName()
        {
            return Name;
        }
    }

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
