namespace Csharp_function
{
    public class Program
    {
        static void Main(string[] args)
        {


            //AddClick(40, 9);
            //AddClick(50, 5);
            //AddClick(23, 89);
            //AddClick(45, 65);

            //ShowName();
            //RemoveNumber(50, 500);
            //string myName = NameOfThings("Princely", "Victor");
            //int add = RemoveNumber(50, 500);
            //Console.WriteLine($"{add} this can happen also");
            //Console.WriteLine($"{RemoveNumber(10, 70)} this is cool");.

            //Console.WriteLine($"{RemoveNumber(500, 700)} this is also cool");
            //Console.WriteLine($"my name is {myName}");
            //Console.WriteLine(isOddNumber(21));

            //int[] numbers = { 2, 6, 8, 9, 4, 3, 0, 8, 5, 8, 0, 8 };
            //string[] foods = { "apple", "oraange", "coconuts", "pear", "corn" };
            //int size = numbers.Length;
            //Console.WriteLine(size);
            //Console.WriteLine(numbers.Average());
            //int many = numbers.Count(num => num == 8);
            //string startwith = foods.Where(x => x.StartsWith('c')).Last();
            //Console.WriteLine(startwith);
            //Console.WriteLine(many);


            //Random rand = new Random();
            //int randomNumber = rand.Next(5, 50);
            //Console.WriteLine(randomNumber);

            //Console.WriteLine(TimeTable(3));
            //int num = 1;
            //while (num <= 20)
            //{

            //    if(num % 2 == 0)
            //    {
            //        Console.WriteLine($"This is an EVEN number: {num }");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"This is an ODD number: { num}");
            //    }
            //    num++;
            //}

            //    Console.ReadLine();
            //}
            //public static void AddClick(int num1, int num2)
            //{

            //    Console.WriteLine(num1 + num2);

            //}
            //public static int  RemoveNumber(int num1, int num2)
            //{
            //    return num1 - num2;
            //}
            //public static void ShowName()
            //{
            //    Console.WriteLine("Povicky is my name;");
            //}
            //public static string NameOfThings(string firstName, string secondName)
            //{
            //    return firstName+ " " + secondName;
            //}
            //public static bool isOddNumber(int num)
            //{
            //    if(num % 2 == 0)
            //    {
            //        return false;

            //    }
            //    return true;
            //}
            //public static string TimeTable(int num)
            //{
            //    string classof;

            //    switch (num)
            //    {
            //        case 0:
            //            classof = "Ui Ux";
            //            break;
            //        case 1:
            //            classof = "Product Managers";
            //            break;
            //        case 3:
            //            classof = "FrontEnd DEv";
            //            break;
            //        case 4:
            //            classof = " BackEnd DEv";
            //            break;
            //        case 5:
            //            classof = "CyberSecurity";
            //                break;
            //        default:
            //            classof = " invalid student";
            //            break;

            //    }
            //    return classof;

            //Object1

            Person person1 = new Person("Jamon", "Nigeria", 100);
            

            Person person2 = new Person();
            person2.Name = "Akpabio";
            person2.Country = "Ghana";
            person2.Age = 15;

            Person person3 = new Person();
            person3.Name = "Povicky";
            person3.Country = "Cameron";
            person3.Age = 13;

            Person person4 = new Person();
            person4.Name = "dodo";
            person4.Country = "Usa";
            person4.Age = 30;

            //Console.WriteLine(person2.Age);
            person4.FavouriteDrink("PalmWine");
            person1.FavouriteDrink("Fanta");
        }
       
           


    }
}
