using Decorator.StudentDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractStudent abstractStudent = new Student();
            int res=abstractStudent.Execute(1,2);
            Console.WriteLine(res);
            Console.WriteLine("************************************************************");
            abstractStudent =new SumDecoratorStudent(abstractStudent);
            int resDec=abstractStudent.Execute(3,4);
            Console.WriteLine(resDec);
            Console.ReadLine();
        }
    }
    public class Student : AbstractStudent
    {
        public override int Execute(int a, int b)
        {
            return a + b; 
        }
    }
}
