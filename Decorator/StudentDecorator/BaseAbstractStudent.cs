using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.StudentDecorator
{
    public class BaseAbstractStudent : AbstractStudent
    {
        private AbstractStudent _abstractStudent;
        public BaseAbstractStudent(AbstractStudent abstractStudent)
        {
            _abstractStudent = abstractStudent;
        }
        public override int Execute(int a, int b)
        {
            return this._abstractStudent.Execute(a, b);
        }
    }
}
