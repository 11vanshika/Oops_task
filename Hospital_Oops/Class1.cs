using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Oops
{
    public class Hp
    {
        private int Id;
        private int totalNumberOfDoctor;
        private int totalNumberOfNurse;
        private int totalNumberOfemployee;

        public int id
        {
            set { Id = value; }
            get { return Id; }
        }
       public int TotalNumberOfDoctor
        {
            set { totalNumberOfDoctor = value; }
            get { return totalNumberOfDoctor; }
        }
        public int TotalNumberOfNurse
        {
            get { return totalNumberOfNurse; }
            set { totalNumberOfNurse = value; }
        }
        public int TotalNumberOfEmployee
        {
            get { return totalNumberOfemployee; }
            set { totalNumberOfemployee = value; }
        }
       
        public int TotalNumber()
        {
         int sum =  TotalNumberOfDoctor + TotalNumberOfNurse + TotalNumberOfEmployee;
            return sum;
        }
    }
}
