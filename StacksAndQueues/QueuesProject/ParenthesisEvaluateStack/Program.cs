using System;

namespace ParenthesisEvaluateStack
{
    class Program
    {
        static void Main(string[] args)
        {
            String expression;

            Console.Write("Enter an expression with parentheses : ");
            expression = Console.ReadLine();

            if (IsValid(expression))
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

            Console.ReadLine();
        }

        private static bool IsValid(String expression)
        {
            var stack = new StackArray<char>(50);

            char ch;

            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(' || expression[i] == '{' || expression[i] == '[')
                    stack.Push(expression[i]);

                if (expression[i] == ')' || expression[i] == '}' || expression[i] == ']')
                {
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("RIGHT parentheses are more than the LEFT parentheses");
                        return false;
                    }

                    ch = stack.Pop();
                    if (!MatchParentheses(ch, expression[i]))
                    {
                        Console.WriteLine("The mismatched parentheses are : ");
                        Console.WriteLine($"{ch} and {expression[i]}");
                        return false;
                    }
                }
            }

            if (stack.IsEmpty())
            {
                Console.WriteLine("The force is balanced young padawan.");
                return true;
            }

            Console.WriteLine("LEFT parentheses are more than RIGHT parentheses");
            return false;
        }

        private static bool MatchParentheses(char ch, char ch2)
        {
            if (ch == '[' && ch2 == ']') return true;
            if (ch == '{' && ch2 == '}') return true;
            if (ch == '(' && ch2 == ')') return true;

            return false;
        }
    }
}
