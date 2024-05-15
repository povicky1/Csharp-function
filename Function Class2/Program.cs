using Csharp_function;
using System;

namespace Function_Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edo edo = new Edo( Id, Region, Name);
            edo.Id = 5;
            edo.Region = "South south " ;
            


            
            Kano kano = new Kano();
            kano.Id = 8;
            kano.Region = "north east";

            Console.WriteLine(kano.NameofTribe());

        }
    }
}
