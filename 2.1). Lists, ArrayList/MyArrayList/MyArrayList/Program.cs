using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    class NewArrayListProgram
    {
        public static ArrayList arrayList = new ArrayList();
        public static Boolean flag = true;
        static void Main(string[] args)
        {
            while (flag)
            {
                Console.WriteLine("\n1. Insert \t2. Remove \n3. Find \t4. Display\n5. Count\t6. Exit");
                Console.Write("Please enter your Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        arrayList = Insert(arrayList);
                        break;
                    case "2":
                        arrayList = Remove(arrayList);
                        break;
                    case "3":
                        Find(arrayList);
                        break;
                    case "4":
                        Display(arrayList);
                        break;
                    case "5":
                        Count(arrayList);
                        break;
                    case "6":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct choice !!");
                        break;
                }
            }
        }
    }
