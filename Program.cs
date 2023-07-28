using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLap03._1Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e= new Employee();
            e.id = 1;
            e.name = "Đàm Quốc Dân";
            e.salaryLevel = 50;
            e.basicSalary = 300;
            e.Display();
            double Income = e.GetInCome();
            Console.WriteLine("Thu nhập:{0}", Income);
            Console.ReadKey() ;
        }
    }
}
