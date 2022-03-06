using System.Collections.Generic;
using System.Linq;

namespace Composite_Pattern
{
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


}
