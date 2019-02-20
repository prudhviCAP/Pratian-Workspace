using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee();
            Console.Write("Enter employee id : ");
            empObj.EmpId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your first name : ");
            empObj.FName = Console.ReadLine();

            Console.Write("Enter your last name : ");
            empObj.LName = Console.ReadLine();

            string name = empObj.FullName;

            Console.Write("Enter your basic salary : ");
            empObj.BSal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Address : ");
            empObj.Address = Console.ReadLine();

            bool opt = true;
            int flag = 0;
            while (opt) { 
            Console.WriteLine("Employee Attendance System");
            Console.WriteLine("\t1. Sign In");
            Console.WriteLine("\t2. Sign Out");
            Console.WriteLine("\t3. Exit ");

            Console.Write("Please Pass your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
                {
                    switch (choice)
                    {
                        case 1:
                            bool signIn;
                            if (flag == 0)
                            {
                                signIn = empObj.SignIn(name);
                                flag = 1;
                            }
                            else
                            {
                                Console.WriteLine("You have already logged in");
                            }
                            break;
                        case 2:
                            bool signOut;
                            if (flag == 1)
                            {
                                signOut = empObj.SignOut();
                                flag = 0;
                            }
                            else
                            {
                                Console.WriteLine("Employee has already signed out");
                            }
                            break;
                        default:
                            if (flag == 1)
                            {
                                Console.WriteLine("Please Sign out before exit");
                            }
                            else
                            {
                                opt = false;
                            }
                            break;
                    }
                }
            }
        }
    }
}
