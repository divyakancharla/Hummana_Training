using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda Exp and Delegates-Call a method by using variable name
            Action<string> action = (name)=>Console.WriteLine(name); 
            action("sfsd");
            Func<string,string> Funtion =name =>name+"kancharla";
            Funtion("Divya");
            //Linq-Update,Operate,Manipulate using Linq Methods used in arrays and Lists
            List<Student> List = new List<Student>() {new Student{StudentId=10,Name="Divya",Branch="IT",Gender="F",CGPA=8.8f},
                                                      new Student{StudentId=1,Name="Dhruv",Branch="CIVIL",Gender="M",CGPA=5.8f},
                                                      new Student{StudentId=02,Name="Rahul",Branch="EEE",Gender="M",CGPA=6.8f },
                                                      new Student{StudentId=20,Name="Danya",Branch="ECE",Gender="F",CGPA=9.8f },
                                                      new Student{StudentId=102,Name="Bhanu",Branch="IT",Gender="M",CGPA=6.8f },
                                                      new Student{StudentId=112,Name="Kavya",Branch="CSE",Gender="F",CGPA=7.8f } };
            List<Student> StudentData=List.Where(e=>e.Branch=="IT"&&e.Gender=="F").ToList();
            var StudentDataSingle = List.SingleOrDefault(e => e.StudentId==10);
            Console.WriteLine(StudentDataSingle.Name);
            foreach (var i in StudentData) { Console.WriteLine("{0} {1}",i.Name,i.CGPA); }
            List<int> Aggregate = new List<int>() { 1, 2, 3, 4, 5 };
            //Aggregate-takes min two arguments used in mathematical operations,its an extension method
           //every iteration executes like a method
            var AgregateResult = Aggregate.Aggregate((a,b) => a * b);
            Console.WriteLine(AgregateResult);
            //any-acts like OR, All-AND
            string[] names = { "Ram", "Aaj", "Remo", "Ravi", "Rangila" };

            bool IsFisrtLetterR = names.AsQueryable().Any(name => name.StartsWith("R"));
            Console.WriteLine(IsFisrtLetterR);
            //Except-compare Ienumerable first one with second 
            List<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            List<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var Result = strList1.Except(strList2);
            //Distinct
            var ResultDistinct = strList1.Distinct();

            foreach (string str in Result)
                Console.WriteLine(str);
            //GroupBy
            var GroupbyResult = List.GroupBy(e => e.Branch).OrderBy(e=>e.Key).ToList();
           foreach (var i in GroupbyResult)
            { Console.WriteLine("GroupBy Key {0}", i.Key);
                foreach (var ii in GroupbyResult)
                Console.WriteLine("GroupBy Value {0}", ii);  
            }
        }
    }
}
