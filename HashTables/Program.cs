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
            //UC-3
            Console.WriteLine("Welcome to Hash Tables");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(6);
            hash.Add(1,"Paranoids");
            hash.Add(2, "are");
            hash.Add(3, "not");
            hash.Add(4, "paranoid");
            hash.Add(5, "because");
            hash.Add(6, "they");
            hash.Add(7, "are");
            hash.Add(8, "paranoid");
            hash.Add(9, "but");
            hash.Add(610, "because");
            hash.Add(10,"they");
            hash.Add(11, "keep");
            hash.Add(12, "putting");
            hash.Add(13, "themselves");
            hash.Add(14, "deliberately");
            hash.Add(15, "into");
            hash.Add(16, "paranoid");
            hash.Add(17, "avoidable");
            hash.Add(18, "situation");


            Console.WriteLine("Before Removing: ");
            for (int i = 0; i <= 18; i++)
            {
                Console.Write(hash.Get(i) + " ");
            }

            hash.Remove(17);
            Console.WriteLine();
            Console.WriteLine("After Removing: ");
            for (int i = 0; i <= 18; i++)
            {
                Console.Write(hash.Get(i)+" ");
            }
            Console.ReadLine();
        }
    }
}
