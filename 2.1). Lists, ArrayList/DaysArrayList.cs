// C# program for insertion in ArrayList (Week Days and Months)

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysArrayList
{
    class DaysArrayListProgram
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(7);

            arr.Add("Sunday");
            arr.Add("Monday");
            arr.Add("Tuesday");
            arr.Add("Wednesday");
            arr.Add("Thusday");
            arr.Add("Friday");
            arr.Add("Saturday \n");

            Console.WriteLine("Days in Week are:-");

            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }

            arr.Insert(0, "DAYS : \n");
            arr.Insert(8, "MONTHS : \n");
            arr.Insert(9, "January");
            arr.Insert(10, "February");
            arr.Insert(11, "March");
            arr.Insert(12, "April");
            arr.Insert(13, "May \n");

            Console.WriteLine("The elements in the arraylist are after the insert operation: \n");

            //Console.WriteLine();

            foreach (object obj in arr)

            {
                Console.WriteLine(obj);
            }
        }
    }
}
