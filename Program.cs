﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkdList_Test
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            LinkedList number = new LinkedList();
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddAfter(0,20);

            //number.Add(56);
            //number.Add(30);
            //number.Add(70);

            //number.AddFirst(56);
            //number.AddFirst(30);
            //number.AddFirst(70);

            number.AddLast(56);
            number.AddLast(30);
            number.AddLast(70);
            number.AddAfter(2, 40);
           // int a =number.Length();
           // Console.WriteLine(a);
            //number.Pop();
          //  number.PopLast();;
            number.Find(30);
        }
    }
}