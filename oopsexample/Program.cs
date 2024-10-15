namespace oopsexample
{
    class Student
    {
        private string _Name;
        private int _marks;

        public string Name
        {
            get
            {
                return _Name;   
            }
            set
            {
                _Name = value;
            }
        }
        public int Marks
        {
            get
            {
                return _marks;
            }
            set
            {
                if (value >0 && value < 100)
                {
                    _marks = value;
                }
                else
                {
                    Console.WriteLine("enter correct marks");
                }
            }
        }
        public void DisplayMarks()
        {
            Console.WriteLine("The marks of {0} is {1}", Name, Marks);
        }
    }


    internal class Program
    {
       static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("enter your name");
            s.Name = Console.ReadLine();
            Console.WriteLine("enter your marks");
            s.Marks = int.Parse(Console.ReadLine());
            s.DisplayMarks();
        }
       
        
    }
}
