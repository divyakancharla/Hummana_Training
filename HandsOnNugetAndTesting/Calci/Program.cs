using System;

namespace Calci
{
    class Program
    {
        static void Main(string[] args)
        {
           CalculatorTask obj=new CalculatorTask();
           var Result=obj.Calculate();
           if(Result==-1){
               Console.WriteLine("Invalid Choice");
           }
           else{
            Console.WriteLine("Answer is:"+" "+Result);
           }
        }
    }
}
