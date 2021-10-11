using System;
using System.Collections.Generic;
using System.Text;

namespace Car_simulation
{
    class Simulation
    {
        string Bmw;
        string color;
        int tank;
        private int loadingpetrol; // benzin yuklemek
        private int burngasoline; // benzin yandirmaq
        private int unused;//istifade edilmemis benzin
        private int fueltank; // polnu bak 
        private string powerhouse;   //at gucu     
        private int speed;//suret



        public Simulation()
        {

        }

        public Simulation(string Cartype)
        {
            if (Cartype== "Bmw") ;
            {
                
                fueltank = 40;
                unused = 40;
                burngasoline = 0;
                Console.WriteLine("no need for gasoline");
            }
            
        }
        public void  station()
        {
            if (burngasoline>unused)
            {
                Console.WriteLine("refuel the car");
            }
            else
            {

                Console.WriteLine("Fuel");
            }

        }
        public void burn()
        {
            if (speed>=100&&speed<=200)
            {
                burngasoline = 06;
                Console.WriteLine("xerclediyi benzin miqdari"+burngasoline);
            }
            else
            {
                if (speed>=150&&speed<=300)
                {
                    burngasoline = 1;
                    Console.WriteLine( "xerclediyi benzin miqdari"+burngasoline);
                }
            }
        }


    }
   

}
