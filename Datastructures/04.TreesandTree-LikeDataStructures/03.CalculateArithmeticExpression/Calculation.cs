using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CalculateArithmeticExpression
{
    public class Calculation
    {
        public static double CalculateArithmeticTree(Tree<string> tree)
        {
            if (!char.IsDigit(tree.Left.Value[0]) && tree.Left.Value.Length == 1)
            {
                CalculateArithmeticTree(tree.Left);
            }
            if (!char.IsDigit(tree.Right.Value[0]) && tree.Right.Value.Length == 1)
            {
                CalculateArithmeticTree(tree.Right);
            }
            else
            {
                tree.Value = CalculateNode(tree).ToString();
            }
            return double.Parse(tree.Value);

        }

        private static double CalculateNode(Tree<string> node)
        {
            switch (node.Value)
            {
                case "*":
                    return double.Parse(node.Left.Value) * double.Parse(node.Right.Value);
                case "/":
                    return double.Parse(node.Right.Value) / double.Parse(node.Left.Value);
                case "-":
                    if (node.Parent == null)
                    {
                        return double.Parse(node.Right.Value) - double.Parse(node.Left.Value);
                    }
                    return double.Parse(node.Left.Value) - double.Parse(node.Right.Value);
                case "+":
                    return double.Parse(node.Left.Value) + double.Parse(node.Right.Value);
            }
            return 0;
        }

        public static Stack<string> RPN(string expression)
        {
            Stack<string> output = new Stack<string>();
            Stack<char> operators = new Stack<char>();

            string storage = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]) || expression[i] == '.')
                {
                    storage += expression[i];
                }
                else if (char.IsWhiteSpace(expression[i]))
                {
                    if (storage == string.Empty)
                    {
                        continue;
                    }
                    if ("-" == storage)
                    {
                        if (operators.Count == 0 || CheckPrecenent('-') >= CheckPrecenent(operators.Peek()))
                        {
                            operators.Push('-');
                        }
                        else
                        {
                            output.Push(operators.Pop().ToString());
                            operators.Push('-');
                        }
                    }
                    else
                    {
                        output.Push(storage);
                    }
                    storage = string.Empty;
                }
                else
                {
                    char c = expression[i];
                    switch (expression[i])
                    {
                        case '-':
                            storage += c;
                            break;
                        case '*':
                        case '/':
                        case '+':
                            if (operators.Count == 0 || (CheckPrecenent(c) >= CheckPrecenent(operators.Peek())))
                            {
                                operators.Push(expression[i]);
                            }
                            else
                            {
                                output.Push(operators.Pop().ToString());
                                operators.Push(expression[i]);
                            }
                            break;
                        case '(':
                            operators.Push(c);
                            break;
                        case ')':
                            if (storage != string.Empty)
                            {
                                output.Push(storage);
                                storage = string.Empty;
                            }
                            while (operators.Peek() != '(')
                            {
                                output.Push(operators.Pop().ToString());
                            }
                            operators.Pop();
                            break;
                    }
                }

            }
            if (storage != string.Empty)
            {
                output.Push(storage);
            }
            while (operators.Count > 0)
            {
                output.Push(operators.Pop().ToString());
            }
            return output;
        }

        public static Tree<string> CreateArithmeticTree(string expression)
        {
            Stack<string> rpnStack = new Stack<string>();
            var stack = RPN(expression);
            while (stack.Count > 0)
            {
                rpnStack.Push(stack.Pop());
            }
            stack = new Stack<string>();
            Stack<Tree<string>> resultNode = new Stack<Tree<string>>();
            while (rpnStack.Count > 0)
            {

                if (!char.IsDigit(rpnStack.Peek()[0]) && rpnStack.Peek().Length == 1)
                {
                    Tree<string> currentNode;
                    currentNode = new Tree<string>(rpnStack.Pop());

                    currentNode.Left = resultNode.Count > 0 ? resultNode.Pop() : new Tree<string>(stack.Pop());
                    currentNode.Right = resultNode.Count > 0 ? resultNode.Pop() : new Tree<string>(stack.Pop());

                    currentNode.Left.Parent = currentNode;
                    currentNode.Right.Parent = currentNode;

                    resultNode.Push(currentNode);
                }
                else
                {
                    stack.Push(rpnStack.Pop());
                }
            }
            Tree<string> result = resultNode.Pop();
            return result;

        }

        private static int CheckPrecenent(char c)
        {
            switch (c)
            {
                case '-': return 1;
                case '+': return 1;
                case '*': return 2;
                case '/': return 2;
            }
            return 0;
        }
    }
}
