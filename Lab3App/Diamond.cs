using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond:Treasure
    {
        public Diamond(string description, int score = 0):base(description, score)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Diamond {0} is displayed", Description);
        }


    }
}
