using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace ExpressionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionVoid();
            Console.WriteLine("Hello World!");
        }
        public static void ExpressionVoid()
        {
            //Func<int, int, int> func = (m, n) => m * n + 2;
            //Expression<Func<int, int, int>> exp = (m, n) => m * n + 2;
            //ParameterExpression mPara = Expression.Parameter(typeof(int), "m");
            //ParameterExpression nPara = Expression.Parameter(typeof(int),"n");
            //ConstantExpression numPa = Expression.Constant(2);
            //BinaryExpression multiply = Expression.Multiply(mPara, nPara);
            //BinaryExpression addExp = Expression.Add(multiply, numPa);
            //Expression<Func<int,int,int>> expExp = Expression.Lambda<Func<int,int,int>>(addExp,new ParameterExpression[] { mPara,nPara});
            //int expRes = expExp.Compile().Invoke(2,2);

            //Expression<Func<People, bool>> funcPeo = p => p.Id.ToString().Equals("5");

            //ParameterExpression parameterExpression = Expression.Parameter(typeof(People), "x");
            //Expression field = Expression.Field(parameterExpression, typeof(People).GetField("Id"));
            //var toString = typeof(People).GetMethod("ToString");
            //var callTostring = Expression.Call(field, toString, new Expression[0]);
            //var equals = typeof(People).GetMethod("Equals");
            //var constant = Expression.Constant("5", typeof(string));
            //var callEquals = Expression.Call(callTostring, equals, new Expression[] { constant });
            //Expression<Func<People, bool>> expPeo = Expression.Lambda<Func<People, bool>>
            //    (callEquals, new ParameterExpression[] { parameterExpression });
            //var res = expPeo.Compile().Invoke(new People() { Id = 5, Name = "123", Age = 5 });

            ParameterExpression peoplePara = Expression.Parameter(typeof(People), "p");
            List<MemberBinding> list = new List<MemberBinding>();
            foreach (var item in typeof(PeopleCopy).GetFields())
            {
                MemberExpression member = Expression.Field(peoplePara,typeof(People).GetField(item.Name));
                MemberBinding binding = Expression.Bind(item, member);
                list.Add(binding);
            }
            MemberInitExpression initExpression = Expression.MemberInit(Expression.New(typeof(PeopleCopy)), list);
            Expression<Func<People, PeopleCopy>> expressionConvert = Expression.Lambda<Func<People, PeopleCopy>>(initExpression, new ParameterExpression[] {  peoplePara });
            var resPeople = expressionConvert.Compile().Invoke(new People() { Id=29,Name="小吕",Age=29});
            Console.WriteLine($"{123}");
        }
    }
    public class People
    {
        public int Id;
        public string Name;
        public int Age;
    }
    public class PeopleCopy
    {
        public int Id;
        public string Name;
        public int Age;
    }
}
