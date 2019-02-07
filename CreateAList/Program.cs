using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(50);
            myList.Add(50);
            myList.Add(50);
            myList.Add(50);
            myList.Add(50);
            myList.Add(50);
            myList.Add(50);

            myList.RemoveAt(1);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            foreach (int j in myList)
            {
                Console.WriteLine(j);
            }
        }
    }
}
