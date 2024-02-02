using System;

namespace stockPurchaseSell_MaximumProfit
{
    class Program
    {
        public static int maxProfit(int[] stocks, int size)
        {
            int buy = 0, sell = 0;

            int currMin = 0;
            int currProfit = 0;
            int maxProfit = 0;

            for(int i = 0; i < size; i++)
            {
                if(stocks[i] < stocks[currMin])
                {
                    currMin = i;
                }

                currProfit = stocks[i] - stocks[currMin];

                if(currProfit > maxProfit)
                {
                    buy = currMin;
                    sell = i;
                    maxProfit = currProfit;
                }
            }

            Console.WriteLine("Purchase Day is : " + buy + " at price " + stocks[buy]);
            Console.WriteLine("Sell Day is : " + sell + " at price " + stocks[sell]);

            return maxProfit;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 10, 150, 6, 67, 61, 16, 86, 6, 67, 78, 150, 3, 28, 143 };

            Console.WriteLine("Profit : " + maxProfit(first, first.Length));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Purchase Day is : 2 at price 6
Sell Day is : 10 at price 150
Profit : 144
*/
