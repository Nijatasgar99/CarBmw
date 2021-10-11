using System;

namespace Car_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation Bmw = new Simulation("Bmw");
            Bmw.burn();
            Bmw.station();
            Console.WriteLine();
            
        }
    }
}
