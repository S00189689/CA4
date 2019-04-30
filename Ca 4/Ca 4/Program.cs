using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ca_4
{
    class Program
    {
        /*David Gordon
         * Started 29/4/2019
         * It sligo Student
         * 
         */

        private static string line_In;


        static void Main(string[] args)
        {

            int a = 5;

            // dont forget to incress the array 

            Player[] team = new Player[a];

            // note for the constuctor

            //Players_Name = p
            //Goles_Scored = g
            //Matches_Played = m
            //Player_Number = Pn
            // the jouner player
            //age = a

            //Players name , Goles scored, Maches played ,players numbers anad if a jouner player age 

            team[0] = new Player("arron", -2, 5, 10);
            team[1] = new Player("jhon", 1, 5, 11);
            team[2] = new Junior("donky", 4, 4, 12, 18);
            team[3] = new Junior("micky", 1, 1, 22, 17);
            team[4] = new Player("ollie", 1, 5, 10);


            for (int i = 0; i < a ; i++)
            {
                Console.WriteLine();
                Console.WriteLine(team[i].ToString());
                Console.WriteLine(team[i].CalcBonus());
            }


        }
        //static void CSV_File()
        //{

        //    FileStream fs = new FileStream(@"Book1.txt", FileMode.Open, FileAccess.Read);

        //    StreamReader sr = new StreamReader(fs);

        //    string[] field_Arrary = new string[3];


        //    line_In = sr.ReadLine();

        //    while (line_In != null)
        //    {

        //        field_Arrary = line_In.Split(',');

        //        line_In = sr.ReadLine();

        //    }

        //    sr.Close();

        //}
    }
}
