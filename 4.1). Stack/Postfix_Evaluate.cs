using System;
using System.Collections.Generic;

namespace Postfix_Evaluate
{
    class Program
    {
        public static int PostfixEvaluate(string expn)
        {
            Stack<int> stk = new Stack<int>();
            string[] tokens = expn.Split(' ');

            foreach (string token in tokens)
            {
                if ("+-*/".Contains(token))
                {
                    int num1 = stk.Pop();
                    int num2 = stk.Pop();

                    switch (token)
                    {
                        case "+":
                            stk.Push(num1 + num2);
                            break;
                        case "-":
                            stk.Push(num1 - num2);
                            break;
                        case "*":
                            stk.Push(num1 * num2);
                            break;
                        case "/":
                            stk.Push(num1 / num2);
                            break;
                    }
                }
                else
                {
                    stk.Push(Convert.ToInt32(token));
                }

            }
            return stk.Pop();
        }

        static void Main(string[] args)
        {
            string expn = "6 5 2 3 + 8 * + 3 + *";
            int value = PostfixEvaluate(expn);
            Console.WriteLine("Result after Evaluation: " + value);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Result after Evaluation: 288
*/
