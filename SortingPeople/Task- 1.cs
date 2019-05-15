using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleTask1;

namespace PeopleTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<People> Person = new List<People>();
            Person.Add(new People());
            Person[0].firstName = "David";
            Person[0].lastName = "Warner";
            Person[0].Age = 80;
            Person[0].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";//

            Person.Add(new People());
            Person[1].firstName = "Shikhar";
            Person[1].lastName = "Dhawan";
            Person[1].Age = 25;
            Person[1].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[2].firstName = "KL";
            Person[2].lastName = "Rahul";
            Person[2].Age = 17;
            Person[2].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";


            Person.Add(new People());
            Person[3].firstName = "Rishabh";
            Person[3].lastName = "Pant";
            Person[3].Age = 19;
            Person[3].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";


            Person.Add(new People());
            Person[4].firstName = "Mahinder Singh";
            Person[4].lastName = "Dhoni";
            Person[4].Age = 65;
            Person[4].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[5].firstName = "Andre";
            Person[5].lastName = "Russel";
            Person[5].Age = 25;
            Person[5].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[6].firstName = "Hardik";
            Person[6].lastName = "Pandya";
            Person[6].Age = 33;
            Person[6].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[7].firstName = "Shreyas";
            Person[7].lastName = "Gopal";
            Person[7].Age = 75;
            Person[7].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[8].firstName = "Kagiso";
            Person[8].lastName = "Rabada";
            Person[8].Age = 45;
            Person[8].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[9].firstName = "Imran";
            Person[9].lastName = "Tahir";
            Person[9].Age = 41;
            Person[9].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

            Person.Add(new People());
            Person[10].firstName = "Jasprit";
            Person[10].lastName = "Bumrah";
            Person[10].Age = 39;
            Person[10].flag = null; //Person[0].Age <= 19 ? "teenager" : "Not a teen";

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
                opeople.flag = opeople.Age <= 19 ? "Teenager" : "No";
                
                /*Console.WriteLine(opeople.firstName + " " + opeople.lastName);
                Console.WriteLine("this person is a" + " " + opeople.flag);
                Console.WriteLine("\n");*/
            }
            Console.WriteLine("\nThese are the Teens  \n");
            foreach (var opeople in Person)
            {
                if (opeople.flag == "Teenager")
                    Console.WriteLine(opeople.firstName + " " + opeople.lastName + " " +"is a" + " "+opeople.flag);

            }
            Console.ReadLine();


        }
    }
}
