using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            List<People> Person = new List<People>();
            Person.Add(new People());
            Person[0].firstName = "Rahul";
            Person[0].lastName = "Ganesh";
            Person[0].Age = 80;
            Person[0].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[1].firstName = "BJ";
            Person[1].lastName = "GaneshMoorthy";
            Person[1].Age = 25;
            Person[1].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";




            Person.Add(new People());
            Person[2].firstName = "Man";
            Person[2].lastName = "Poliant";
            Person[2].Age = 17;
            Person[2].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";


            Person.Add(new People());
            Person[3].firstName = "Hardik";
            Person[3].lastName = "Pandya";
            Person[3].Age = 19;
            Person[3].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";


            Person.Add(new People());
            Person[4].firstName = "Simon";
            Person[4].lastName = "Jones";
            Person[4].Age = 65;
            Person[4].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[5].firstName = "Ganesh";
            Person[5].lastName = "Panesh";
            Person[5].Age = 25;
            Person[5].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[6].firstName = "Halal";
            Person[6].lastName = "Haludeen";
            Person[6].Age = 33;
            Person[6].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[7].firstName = "Kedar";
            Person[7].lastName = "Jadhav";
            Person[7].Age = 75;
            Person[7].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[8].firstName = "Kane";
            Person[8].lastName = "Williamson";
            Person[8].Age = 45;
            Person[8].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[9].firstName = "Yelawolf";
            Person[9].lastName = "Catfish Billy";
            Person[9].Age = 41;
            Person[9].flag = Person[0].Age <= 19 ? "teenager" : "Not a teen";


            Console.WriteLine("The following are the senior citizens \n");
            foreach (People opeople in Person)
            {

                if (opeople.Age > 60)
                {

                    Console.WriteLine(opeople.SeniorData());
                    Console.WriteLine("This person is a senior citizen");
                    Console.WriteLine("\n");
                }
            }



            Console.WriteLine("The following are the teens \n");

            foreach (People opeople in Person)
            {

                if (opeople.Age <= 19)
                {
                    Console.WriteLine(opeople.teenagerData());
                    Console.WriteLine("This person is a teenager");
                    Console.WriteLine("\n");

                }
                // Console.WriteLine("This person is a " + opeople.flag );//
            }

            Console.WriteLine("The following are the last names of the first five people on the list \n");

            foreach (People opeople in Person)
            {
                Console.WriteLine(opeople.lastName);
                Console.WriteLine("\n");
                counter++;
                if (counter == 5)
                    break;
            }



            foreach (People opeople in Person)
            {
                Console.WriteLine(opeople.firstName + " " + opeople.lastName);
                Console.WriteLine("this person is a" + " " + opeople.flag);
                Console.WriteLine("\n");
            }

            Console.ReadLine();


        }
    }
}
