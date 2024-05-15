using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_function
{
    public class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }


        public Person()
        {

        }
        public Person(string name, string country, int age)
        {
            Name = name;    
            Country = country;
            Age = age;
        }


        public void  FavouriteDrink(string Brand)
        {
            Console.WriteLine($"this is {Name} favorite Drink {Brand}" );
        }




    }
}
