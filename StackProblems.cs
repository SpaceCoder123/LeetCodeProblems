namespace LeetCode
{
    public class StackProblems
    {
        //1021. Remove Outermost Parentheses (using stack)
        public static string RemoveOuterParentheses(string s)
        {
            Stack<Char> paranthesis = new Stack<Char>();
            string returnString = "";
            foreach (char c in s)
            {
                if (c == '(')
                {
                    paranthesis.Push(c);
                    if (paranthesis.Count != 1)
                        returnString += c;
                }
                else if (c == ')')
                {
                    if (paranthesis.Count != 1)
                    {
                        paranthesis.Pop();
                        returnString += c;
                    }
                    else
                    {
                        paranthesis.Pop();
                    }
                }
            }
            return returnString;
        }
        //1021. Remove Outermost Parentheses (without using stack)
        public static string RemoveOuterParenthesesWOStack(string s)
        {
            string returnString = "";
            int counter = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    counter++;
                    if (counter != 1)
                        returnString += c;
                }
                else if (c == ')')
                {
                    if (counter != 1)
                    {
                        counter--;
                        returnString += c;
                    }
                    else
                        counter--;
                }
            }
            return returnString;
        }
    }
}
