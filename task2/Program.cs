using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
        Generic gen=new Generic();
            gen.Update(70, 90.5, 72, 88, 95);

        }
   
    }

    public class Generic
    {
        public void Update<T1, T2, T3, T4, T5>(T1 mark1, T2 mark2, T3 mark3, T4 mark4, T5 mark5)
            where T1 : IComparable, IConvertible
            where T2 : IComparable, IConvertible
            where T3 : IComparable, IConvertible
            where T4 : IComparable, IConvertible
            where T5 : IComparable, IConvertible
        {
            double sum = Convert.ToDouble(mark1) + Convert.ToDouble(mark2) + Convert.ToDouble(mark3) + Convert.ToDouble(mark4) + Convert.ToDouble(mark5);

            double average = sum / 5;

            Console.WriteLine($"The Average: {average}");
            PrintMarkStatus(mark1, average);
            PrintMarkStatus(mark2, average);
            PrintMarkStatus(mark3, average);
            PrintMarkStatus(mark4, average);
            PrintMarkStatus(mark5, average);
        }



             public void PrintMarkStatus<T>(T mark, double average)
       
            
            where T : IComparable, IConvertible
        {
            // تحويل العلامة إلى double
            double markValue = Convert.ToDouble(mark);

            // مقارنة العلامة بالمتوسط
            if (markValue > average)
            {
                Console.WriteLine($"The Mark: {mark} Above average");
            }
            else if (markValue < average)
            {
                Console.WriteLine($"The Mark: {mark} Below average");
            }
            else
            {
                Console.WriteLine($"The Mark: {mark} Equal to average");
            }






        }
        } }



