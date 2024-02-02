using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
     abstract class Collectable:Displayable
    {
        public string Description;
        public CollectionBoard Board = new CollectionBoard();

        public Collectable(string description) { 
        this.Description = description;
        }

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine("{0} Collected, Congrats!!!", Description);
        }
        public abstract void Display();

    }
}
