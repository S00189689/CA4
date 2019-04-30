using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_4
{
    class Player
    {
        // privat atubrats to this class

        private string _players_name;
        private int _goles_scored, _matches_played;
        private static int _player_number ;

        // the public atubrats to this class
        public string Players_Name
        {
            get { return _players_name; }
            set { _players_name = value;}
        }

        public int Goles_Scored
        {
            get
            {
                if (_goles_scored >= 0)
                    return _goles_scored;
                else
                    return 0;
            }

            set {
                if (_goles_scored >= 0)
                    _goles_scored = value;
                else
                    value =0;

                }
        }
        public int Matches_Played
        {
            get {
                if (_matches_played >= 0)
                    return _matches_played;
                else
                    return 0;

            }

            set
            {
                if (_matches_played >= 0)
                    _matches_played = value;
                else
                    value = 0;

            }
        }
        public static int Player_Number
        {
            get { return _player_number; }
            set { _player_number = value; }
        }

        // the genrial conuctrailers
        public Player()
        {

        }

        public Player ( string p,int g,int m,int Pn )
        {
            Players_Name = p;
            Goles_Scored = g;
            Matches_Played = m;
            Player_Number = Pn;
        }


        // the methoded to calc bonus
        public virtual string CalcBonus ()
        {
            int q;
            q = Goles_Scored * 500;
            return "the amount is " + q;
        }

        // the to string is print out of this class
        public override string ToString()
        {
            return Players_Name + " the Goles Scored "+Goles_Scored + " The Maches played "+Matches_Played +" the player number "+ Player_Number;
        }
    }
}
