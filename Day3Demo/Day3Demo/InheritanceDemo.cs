using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{

    class Person
    {
        #region Properties
        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string Address { get; set; }
        #endregion
    }

    class Trainee : Person
    {
        #region Properties
        public int TraineeId { get; set; }
        public string CourseName { get; set; }
        public int FeesPaid { get; set; }
        #endregion
    }
    class Trainer : Person
    {

    }
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            Trainee tree1 = new Trainee();

            //Person
            
        }
    }
}
