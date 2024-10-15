using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample1
{
    public class Person
    {
        public virtual void speak()
        {
            Console.WriteLine("person speaks");
        }
    }
    public interface IWorker
    {
        void work();
    }
    public class Teacher : Person, IWorker
    {
        public override void speak()
        {
            Console.WriteLine("Teacher speak");
        }
        public void work()
        {
            Console.WriteLine("Teacher teaches");
        }
    }
    public class Doctor : Person, IWorker
    {
        public override void speak()
        {
            Console.WriteLine("Doctor speak");
        }
        public void work()
        {
            Console.WriteLine("Doctor treats patients");
        }
    }

    internal class Hybrid
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.speak();
            teacher.work();
            Doctor doctor = new Doctor();
            doctor.work();
            doctor.speak();
        }
    }
}
