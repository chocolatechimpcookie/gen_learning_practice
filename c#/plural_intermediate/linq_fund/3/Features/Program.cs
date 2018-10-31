using System;
using System.Collections.Generic;
using System.Linq;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Features.Linq;


namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            //last type is the return type, everything before is parameter
            // so this takes an int, return an int 


            Func<int, int, int> add = (x, y) => x + y;
            //there's two parameters, you need paranthesis (x,y)

            // you can use curly braces, but you have to use return

            Action<int> write = x => Console.WriteLine(x);
            //returns void

            write(square(add(3,5)));



            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"}
            };

            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex"}
            };

            //Using var instead of explicitely saying something is IEnumerable<Employee>

            var query = developers.Where
                        (e => e.Name.Length == 5).OrderBy(e => e.Name);

            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer ;
            //^ same thing

            foreach (var employee in query2)
            {
                Console.WriteLine(employee.Name);
            }

            //^basically we are putting a func type in there instead of the one below
        }

  

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
