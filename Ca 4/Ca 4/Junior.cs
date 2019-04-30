using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_4
{
    class Junior : Player
    {
        // privats atubrats 
        private int _age;



        public Junior()
        {

        }

        // Get and set
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Junior (string p, int g, int m, int Pn,int a) :base(  p,  g,  m, Pn)
        {
            Age = a;
        }


        // override for the to calc bonus for the jouner players
        public override string CalcBonus()
        {
            int q = 0;
            if (Matches_Played >= 3)
            {
                q = Goles_Scored * 100;
                return "the bonus is " + q;
            }
            else
                return "the bonus is "+q;
           
        }

        // the string over ride player string;
        public override string ToString()
        {
            return base.ToString() + "the players age " + Age;
        }
    }
}
