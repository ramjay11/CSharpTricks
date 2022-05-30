using System;
using System.Linq;
using System.Collections; // This will allow us to use ArrayList
using System.Collections.Generic; // This will allow us to use Dictionaries

namespace Tutorial11Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code

            ArrayList aList = new ArrayList();
            aList.Add("Huskey");
            aList.Add(90);
            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new Object[] { "Doray", "Patbear", "Milk" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList2.Insert(1, "Turkey");
            ArrayList range = aList2.GetRange(0, 2);
            foreach(object o in aList2)
            {
                Console.WriteLine(o);
            }
            #endregion


        }
    }
}
