using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class HashCollection
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Scott");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 25000.00);
            ht.Add("Mgrid", 1002);
            ht.Add("Phone", "8677912084");
            ht.Add("Email", "rdx@gmail.com");
            ht.Add("Dname", "Sales");
            ht.Add("Location", "Mumbai");
            ht.Add("Did", 30);

           // Console.WriteLine("Hello".GetHashCode());

            foreach (object Key in ht.Keys)
            {
                Console.WriteLine(Key + ": " + ht[Key]);

            }
            Console.ReadLine();

        }
    }
}
