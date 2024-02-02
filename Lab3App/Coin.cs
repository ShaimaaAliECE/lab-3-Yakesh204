using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab3App
{
    class Coin:Treasure
    {
        int Value;

        public Coin(string description, int score = 0, int value = 0): base(description, score)
        {
            this.Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue = Board.TotalValue + Value;
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin {0} is displayed", Description);
        }




    }
}
