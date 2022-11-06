using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-1
            Console.WriteLine("Welcome to Hash Tables");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(6);
            hash.Add(1,"To");
            hash.Add(2, "be");
            hash.Add(3, "or");
            hash.Add(4, "not");
            hash.Add(5, "to");
            hash.Add(6, "be");

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(hash.Get(i));
            }
            Console.ReadLine();
        }
    }
}
