using System.Globalization;

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
                    counter--;
                    if (counter != 1)
                        returnString += c;
                    else
                        counter--;
                }
            }
            return returnString;
        }

        //897. Increasing Order Search Tree // inprogress
        public static BinaryTreeNode IncreasingBST(BinaryTreeNode root)
        {
            Stack<BinaryTreeNode> treeCollection = new Stack<BinaryTreeNode>();
            // base condition
            if (root.left == null && root.right == null)
                return root;
            BinaryTreeNode temp = root;
            while (temp != null)
            {
                if (temp.right != null)
                {
                    temp = temp.right;
                }
                if (temp.left != null)
                {

                }
            }


            return ConstructTree(root, treeCollection);
        }

        public static BinaryTreeNode ConstructTree(BinaryTreeNode root, Stack<BinaryTreeNode> treeCollection)
        {
            if (root.right != null)
            {
                Console.WriteLine(root.val);
                return ConstructTree(root.right, treeCollection);
            }
            if (root.left != null)
            {
                Console.WriteLine(root.val);
                return ConstructTree(root.left, treeCollection);
            }
            return root;
        }

        //1475. Final Prices With a Special Discount in a Shop
        // [8,4,6,2,3] out [4,2,4,2,3]
        // if(
        public static int[] FinalPrices(int[] prices)
        {
            int n = prices.Length;
            int[] output = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    stack.Push(prices[i]);
                    continue;
                }
            }

            return output;
        }
        //1598. Crawler Log Folder
        public static int MinOperations(string[] logs)
        {
            int output = 0;
            foreach (string i in  logs)
            {
                if (i == "./")
                    continue;
                if(i == "../")
                {
                    if (output > 0)
                        output--;
                }
                else
                {
                    output++;
                }
            }
            return output;
        }

        //1700. Number of Students Unable to Eat Lunch
    }
}
