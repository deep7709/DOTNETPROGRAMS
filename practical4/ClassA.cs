using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical4
{
    class ClassA
    {

        public void infixtopostfix(string infix, out string postfix)
        {
            char ch;
            postfix = "";
            Stack<char> a = new Stack<char>();

            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];

                if (isOperator(ch))
                {
                    if (a.Count == 0)
                    {
                        a.Push(ch);
                    }

                    else
                    {

                        if (ch == '(')
                        {
                            a.Push(ch);
                        }

                        else if (ch == ')')
                        {
                            while (a.Peek() != '(')
                            {
                                postfix += a.Pop();
                            }
                            a.Pop();
                       
                        }

                        else
                        {

                            if (priority(ch) > priority(a.Peek()))
                            {
                                a.Push(ch);
                            }
                            else
                            {
                                postfix += a.Pop();
                                i--;
                            }

                        }

                    }

                }

                else
                {
                    postfix += ch;
                }
            }
            foreach (var item in a)
                postfix += item;
        }
        private static int priority(char ch)
        {
            switch (ch)
            {
                case '*':
                    return 2;

                case '+':
                    return 1;

                case '-':
                    return 1;

                case '/':
                    return 2;

                case '(':
                    return 0;

                default:
                    return 5;
            }
        }

        private bool isOperator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '(' || ch == ')') 
                  return true;
            return false;
        }
    }
}
