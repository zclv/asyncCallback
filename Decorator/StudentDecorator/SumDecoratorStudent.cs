using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.StudentDecorator
{
    public class SumDecoratorStudent : BaseAbstractStudent
    {
        public SumDecoratorStudent(AbstractStudent abstractStudent) : base(abstractStudent)
        {
        }
        public override int Execute(int a, int b)
        {
            a = a + 1;
            return base.Execute(a, b);
        }
    }
}
