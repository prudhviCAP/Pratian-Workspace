using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{
    class Employee
    {
        public int EmpId { get; set; }

        //string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}
        String fName;
        string lName;

        public String FName     //Write only property
        {
            //get
            //{
            //    return fName;
            //}
            set
            {
                fName = value;
            }
        }
        public string LName     //Write only property
        {
            //get
            //{
            //    return lName;
            //}
            set
            {
                lName = value;
            }
        }
        public string FullName  //Read only property
        {
            get
            {
                return fName + lName;
            }
        }

        public int BSal { get; set; }
        public string Address { get; set; }

        //operations performed by employee
        System.DateTime logInTime = System.DateTime.Now;
        public bool SignIn(string empName)
        {
            Console.WriteLine("Employee :{0} logged in on {1}", FullName, logInTime);
            return true;
        }

        public bool SignOut()
        {
            System.DateTime logOutTime = System.DateTime.Now;
            Console.WriteLine("Employee :{0} logged out on {1}", FullName, logOutTime);
            Console.WriteLine("Employee :{0} is online for {1}", FullName, (logOutTime - logInTime));
            return true;
        }
    }
}
