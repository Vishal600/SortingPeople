using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTask1
{
    public class People
    {
       public string firstName;
       public string lastName;
       public int Age;
       public string flag;
        public string SeniorData()
        {
            return "The persons name is"+ " " + this.firstName + " " + this.lastName + " and his age is " +" " + this.Age;
        }

        public string teenagerData()
        {
            return "The persons name is" + " " + this.firstName + " " + this.lastName + " and his age is " + " " + this.Age;
        }
    }
}
