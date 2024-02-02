using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
   abstract class Treasure:Collectable
    {
        public int Score;

        public Treasure(string description, int score = 0):base(description)
        {
            this.Score = score;

        }

        public void UpdateTotalScore()
        {
            Board.TotalScore = Board.TotalScore + Score;
            Console.WriteLine("Total Score is updated to: {0}", Board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
            
        }

    }
}
