using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Employee List
            
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { firstName = "Martha", lastName = "Stewart", ID = 1 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Hill", ID = 2 });
            employees.Add(new Employee() { firstName = "Bex", lastName = "Jones", ID = 3 });
            employees.Add(new Employee() { firstName = "Julie", lastName = "Rose", ID = 4 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Stewart", ID = 5 });
            employees.Add(new Employee() { firstName = "Savannah", lastName = "Broma", ID = 6 });
            employees.Add(new Employee() { firstName = "David", lastName = "Ollessies", ID = 7 });
            employees.Add(new Employee() { firstName = "Kawika", lastName = "Ohele", ID = 8 });
            employees.Add(new Employee() { firstName = "John", lastName = "Stewart", ID = 9 });
            employees.Add(new Employee() { firstName = "Hugh", lastName = "Mungous", ID = 10 });

            
            // Create sublist with for loop
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    newList.Add(employee);
                }          
            }

            //Create sublists with Lambda expressions
            List<Employee> newList2 = employees.Where(e => e.firstName == "Joe").ToList();
            List<Employee> newList3 = employees.Where(e => e.ID > 5).ToList();


            //Print
            newList.ForEach(e => Console.WriteLine(e.firstName));
            newList2.ForEach(e => Console.WriteLine(e.firstName));
            newList3.ForEach(e => Console.WriteLine(e.firstName + e.ID));
            Console.ReadLine();
         }
    }
}
