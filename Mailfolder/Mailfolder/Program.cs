using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailfolder
{
  
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter details of mail1.");
            string[] mail1=Console.ReadLine().Split(',');
            DateTime dt1 = Convert.ToDateTime(mail1[5]);
            Mail m1 = new Mail(long.Parse(mail1[0]), mail1[1], mail1[2], mail1[3], mail1[4],dt1, double.Parse(mail1[6]));
            Console.WriteLine("Enter the details of mail2");
            string[] mail2 = Console.ReadLine().Split(',');
            DateTime dt2 = Convert.ToDateTime(mail2[5]);
            Mail m2 = new Mail(long.Parse(mail2[0]), mail2[1], mail2[2], mail2[3], mail2[4],dt2, double.Parse(mail2[6]));

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            


        }
    } 
}
