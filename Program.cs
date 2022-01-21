using System;
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
            //number.Add(56);
            //number.Add(30);
            //number.Add(70);
            number.AddFirst(56);
            number.AddFirst(30);
            number.AddFirst(70);

        }
    }
}