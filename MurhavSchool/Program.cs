using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurhavSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("yossy", "123456789", 99, 77, 95);
            Console.WriteLine(s1);
            Console.WriteLine(s1.Avg());

            Console.WriteLine("++++++++++++++++++++");


            Student s2 = new Student("Dana", "876543219", 88, 70, 100);
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s2.Avg());

            if(s1.Avg()>s2.Avg())
            {
                Console.WriteLine("The stu with max avg:"+s1.GetName());
            }
            else
            {

                Console.WriteLine("The stu with max avg:"+ s2.GetName());
            }
            

        }
    }
}
