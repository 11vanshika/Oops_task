using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Oops
{
    class Class1{
    static void Main(string[] args)
    {
        Hp hospital = new Hp();
            hospital.id = 12;
            hospital.TotalNumberOfDoctor = 23;
            hospital.TotalNumberOfNurse = 13;
            hospital.TotalNumberOfEmployee = 10;
          int result =  hospital.TotalNumber();
            Console.WriteLine("Total Number of Employee" + result);



    }
  }
}
