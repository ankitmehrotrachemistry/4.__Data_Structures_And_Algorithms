using System;
using System.Collections.Generic;

namespace Infix_To_Postfix
{
    class Program
    {
        public static int precedence(char x)
        {
            if (x == '(')
            {
                return (0);
            }
            if (x == '+' || x == '-')
            {
                return (1);
            }
            if (x == '*' || x == '/' || x == '%')
            {
                return (2);
            }
            if (x == '^')
            {
                return (3);
            }
            return (4);
        }
        public static string InfixToPostfix(string expn)
        {
            string output = "";
            char[] outVr = InfixToPostfix(expn.ToCharArray());

            foreach (char ch in outVr)
            {
                output = output + ch;
            }
            return output;
        }
        public static char[] InfixToPostfix(char[] expn)
        {
            Stack<char> stk = new Stack<char>();

            string output = "";
            char outVr;

            foreach (char ch in expn)
            {
                if (ch <= '9' && ch >= '0')
                {
                    output = output + ch;
                }
                else
                {
                    switch (ch)
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                        case '%':
                        case '^':
                            while (stk.Count > 0 && precedence(ch) <= precedence(stk.Peek()))
                            {
                                outVr = stk.Pop();
                                output = output + " " + outVr;
                            }
                            stk.Push(ch);
                            output = output + " ";
                            break;
                        case '(':
                            stk.Push(ch);
                            break;
                        case ')':
                            while (stk.Count > 0 && (outVr = stk.Pop()) != '(')
                            {
                                output = output + " " + outVr + " ";
                            }
                            break;
                    }
                }
            }

            while (stk.Count > 0)
            {
                outVr = stk.Pop();
                output = output + outVr + " ";
            }
            return output.ToCharArray();
        }

        static void Main(string[] args)
        {
            string expn = "10+((3))*5/(16-4)";

            string value = InfixToPostfix(expn);

            Console.WriteLine("Infix Expn: " + expn);
            Console.WriteLine("Postfix Expn: " + value);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Infix Expn: 10+((3))*5/(16-4)
Postfix Expn: 10 3 5 * 16 4 - / +
*/
