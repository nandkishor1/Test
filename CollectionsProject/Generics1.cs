using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class Generics1
    {
        public bool Compare<T>(T a,T b)
        {
            if (a.Equals(b))
                return true;
                return false;
            }
            static void Main()
            {

            Generics1 obj = new Generics1();
            bool result1 = obj.Compare<float>(12.25f,12.205f);
            Console.WriteLine(result1);

            bool result2 = obj.Compare<int>(10, 10);
            Console.WriteLine(result2);
            Console.ReadLine();
            }
        }
    }

