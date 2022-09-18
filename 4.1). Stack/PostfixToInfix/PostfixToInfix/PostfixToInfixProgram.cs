// C# Program to convert Potfix to Infix 

using System;
using System.Collections;

namespace PostfixToInfix
{
    public class Node
    {
        public char _value;
        public Node _left, _right;

        public Node(char _item)
        {
            _value = _item;
            _left = _right = null;
        }
    }

    class PostfixToInfixProgram
    {
        Boolean OperatorCheck(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
                return true;
            return false;
        }

        void _InorderTraversal(Node n)
        {
            if (n != null)
            {
                _InorderTraversal(n._left);
                Console.Write(n._value + " ");
                _InorderTraversal(n._right);
            }
        }

        Node _CreateExpressionTree(char[] postfix)
        {
            //Stack s = new Stack();
            Stack s = new Stack();

            Node n, n1, n2;

            for (int i = 0; i < postfix.Length; i++)
            {
                if (!OperatorCheck(postfix[i]))
                {
                    n = new Node(postfix[i]);
                    s.Push(n);
                }
                else
                {
                    n = new Node(postfix[i]);

                    n1 = (Node)s.Pop();
                    n2 = (Node)s.Pop();

                    n._right = n1;
                    n._left = n2;

                    s.Push(n);
                }
            }

            n = (Node)s.Peek();
            s.Pop();

            return n;
        }

        static void Main(string[] args)
        {
            PostfixToInfixProgram P = new PostfixToInfixProgram();
            String postfix = "xy+zw*i*-";

            char[] charArray = postfix.ToCharArray();

            Node root = P._CreateExpressionTree(charArray);

            Console.WriteLine("Infix is:-");

            P._InorderTraversal(root);
        }
    }
}
