using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groep9_SE7
{
    public class Program
    {
        public static void Main(string[] args)
        {



            using (OutdoorParadise context = new OutdoorParadise())
            {

                //int input = Int32.Parse(Console.ReadLine());

                //List<Employees> employees = context.Employees.ToList(); 

                //Console.WriteLine(employees.Find(i => i.ID == input).Last_Name);

                //List<Training> trainingen = context.Training.ToList();

                //List<Bonus> bonussen = context.Bonus.ToList();


                //List<Training> finalT = trainingen.Where(eid => eid.Emp_ID == input).ToList();

                //List<Bonus> finalB = bonussen.Where(eid => eid.Emp_ID == input).ToList();

                //foreach (var t in finalT)
                //{
                //    Console.WriteLine(t.ToString());
                //}

                //foreach (var b in finalB)
                //{
                //    Console.WriteLine(b.ToString());
                //}



                //    List<Customer> cust = context.Customer.Where(s => s.First_Name != null).ToList();

                //    Console.WriteLine("Customers: ");

                //    foreach (var c in cust)
                //    {
                //        Console.WriteLine(c.First_Name + " " + c.Last_Name);
                //    }

                //    Console.WriteLine("=============== ");
                //    Console.WriteLine("============ ");
                //    List<Employees> emps = context.Employees.ToList();

                //    Console.WriteLine("Employees: ");

                //    foreach (var e in emps)
                //    {
                //        Console.WriteLine(e.First_Name + " " + e.Last_Name);
                //    }
                //}
                //Console.ReadKey();

                Application.Run(new Form1(context));
                Console.ReadKey();
            }
        }
    }
}
