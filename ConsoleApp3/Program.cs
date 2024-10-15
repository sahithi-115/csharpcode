using System;

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
                    if (_Age <= 0)
                    {
                        Console.WriteLine("enter the valid age");
    
                    }
                    else
                    {
                        _Age = value;
                
                     }
                }
            }
            public Person()
            {

            }

            public Person(string name, int age, string gender)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }

           

            public void Introduce()
            {
                Console.WriteLine("Hi,my name is {0},i am {1} years old, and i am {2}", Name, Age, Gender);
            }

        }
class Employee :Person
{
    private decimal _salary;
    public decimal salary
    {
        get
        {
            return _salary;
        }
        set
        {
            _salary = value;
        }
    }

    public Employee()
    {

    }
    
    public Employee(decimal salary, string name ,int age ,string gender): base(name,age,gender)
    {
        this.salary = salary;
    }

}
        class Sahithi
        {
            public static void Main(string[] args)
            {
                Person p = new Person("vinay", -25, "male");
                p.Introduce();


            }
        }
