using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssesinInstanceClassFields
{

    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;


        public void Save()
        {
            DataStorage.Store(this);
        }
        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }

        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine($"Name Changed to '{this.GetName()}'");
        }

    }

    class DataStorage
    {
        public static void Store(Employee employee)
        {
            FileStream stream = new FileStream(employee.FirstName + employee.LastName + ".dat", FileMode.Create);

            //Create a StreaWriter Object for writing text into the FileStream

            StreamWriter writer = new StreamWriter(stream);

            //Writing all the data associated with employee

            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            //close the stream writter and its stream.
            writer.Close(); //Automatically close the stream.
        }
        public static int Load(string firstName, string lastName)
        { 
            Employee employee = new Employee();
            FileStream stream = new FileStream(firstName + lastName + ".dat", FileMode.Open);

            StreamReader reader = new StreamReader(stream);
            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary = reader.ReadLine();

            reader.Close();

            return employee;


        
        }
    }
    class Program
    {
        static void Main()
        {

            //Accessing Fields
            Employee employee1 = new Employee();
            
            Employee employee2 = new Employee();
            employee2.SetName("Intigo", "Montaya");
            employee2.Save();


            employee1.FirstName = "Indigo";
            employee1.LastName = "Montoya";
            employee1.Salary = "Too Little";

            IncreaeSalary(employee2);

            employee1 = DataStorage.Load("Indigo", "Montoya");


            Console.WriteLine($"{employee1.GetName()}:{employee1.Salary}");

            Console.WriteLine("{0},{1}:{2}", employee1.FirstName, employee1.LastName, employee1.Salary);
            Console.ReadKey();


        }

        static void IncreaeSalary(Employee employee1)
        {

            employee1.Salary = "Enough to Servive On";

        
        }
        
    }
}
