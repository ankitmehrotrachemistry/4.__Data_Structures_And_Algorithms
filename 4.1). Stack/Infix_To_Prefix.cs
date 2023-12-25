using System;
using System.Collections.Generic;

namespace Infix_To_Prefix
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
        public static void ReplaceParenthesis(char[] a)
        {
            int lower = 0;
            int upper = a.Length - 1;
            while (lower <= upper)
            {
                if (a[lower] == '(')
                {
                    a[lower] = ')';
                }
                else if (a[lower] == ')')
                {
                    a[lower] = '(';
                }
                lower++;
            }
        }
        public static void ReverseString(char[] expn)
        {
            int lower = 0;
            int upper = expn.Length - 1;
            char tempChar;
            while (lower < upper)
            {
                tempChar = expn[lower];
                expn[lower] = expn[upper];
                expn[upper] = tempChar;
                lower++;
                upper--;
            }
        }
        public static string InfixToPrefix(string expn)
        {
            char[] arr = expn.ToCharArray();
            ReverseString(arr);
            ReplaceParenthesis(arr);
            arr = InfixToPostfix(arr);
            ReverseString(arr);
            expn = new string(arr);
            return expn;
        }

        static void Main(string[] args)
        {
            string expn = "10+((3))*5/(16-4)";

            string value = InfixToPrefix(expn);

            Console.WriteLine("Infix Expn: " + expn);
            Console.WriteLine("Prefix Expn: " + value);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Infix Expn: 10+((3))*5/(16-4)
Prefix Expn:  +10 * 3 / 5  - 16 4
*/
