using System.Reflection;
using System.Xml.Linq;

namespace Chatgptdemotest1
{
    class Person
    {
        public string Name;
        private int _Age;
        public string Gender;

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value > 0)
                {
                    _Age = value;

                }
                else
                {
                    Console.WriteLine("enter the valid age");

                }
            }
        }
        public Person()
            {

            }
        public Person(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //method 
        public virtual void Introduce()
        {
            Console.WriteLine("hi, my name is {0},i am {1} year old , and i am {2}",Name,Age,Gender);
        }
    }

    class Employee:Person
    {
        public decimal _salary;

        public virtual decimal salary
        {
            get
            {
                return _salary;
            }
            set {
                _salary = value;
            }
        }

        public Employee()
        {

        }

        public Employee(decimal salary,string Name , int Age , string gender):base(Name,Age,gender)
        {
            this.salary = salary;
        }
        public virtual void Salary()
        {
            Console.WriteLine(Name+":"+salary);
        }

        public override void Introduce()
        {
            Console.WriteLine("hi, my name is {0},i am {1} year old ,i am {2} and I earn {3}", Name, Age, Gender,salary);
        }
    }
    class Manager : Employee
    {
        public override decimal salary
        { 
            get
            {
                return base.salary;
            }
            set
            {
                base.salary = salary+ value * 10 / 100;
            }
             
        }
        public Manager()
        {
        }
        public Manager(string name, int age, string gender, decimal salary)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.salary = salary;
        }
        public override void Salary()
        {
            Console.WriteLine(Name + ":" + salary);
        }


        public override void Introduce()
        {
            Console.WriteLine("hi, my name is {0},i am {1} year old ,i am {2} and I earn {3}", Name, Age, Gender, salary);
        }

    }

    class Program2
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(50000, "sahithi", 22, "f"));
            employees.Add(new Employee(60000, "vinay", 25, "m"));
            employees.Add(new Manager("bujji", 46, "f", 80000));

           foreach( var Employee in employees)
            {
                Employee.Salary();
                
            }
        }
    }
}
