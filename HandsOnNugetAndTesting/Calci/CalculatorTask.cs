using System;
namespace  Calci
{
  public class CalculatorTask
  {

       public int Calculate()
        {
            
              Console.WriteLine("Choose the Below Operations:"+"\n"+"1.Add"+"\n"+"2.Sub"+"\n"+"3.Multiply"+"\n"+"4.Division");
            var _select=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            var _first=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            var _second=int.Parse(Console.ReadLine());
             switch (_select)
             {
                case 1:return _first+_second;
                case 2:return _first-_second;
                case 3:return _first*_second;
                case 4:return _first/_second;
                default: return -1;
                
            }
            

        }
    }
    
}