namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList1 = new LinkedList();

            linkedList1.AddNode(1);
            linkedList1.AddNode(1);
            linkedList1.AddNode(1);
            linkedList1.AddNode(1);
            linkedList1.AddNode(2);
            linkedList1.AddNode(2);
            linkedList1.AddNode(2);
            linkedList1.AddNode(4);
            linkedList1.AddNode(4);
            linkedList1.AddNode(5);
            linkedList1.AddNode(5);
            //linkedList1.AddNode(9);
            //linkedList1.AddNode(9);

            LinkedList linkedList2 = new LinkedList();

            linkedList2.AddNode(5);
            linkedList2.AddNode(6);
            linkedList2.AddNode(1);
            linkedList2.AddNode(8);
            linkedList2.AddNode(4);
            linkedList2.AddNode(5);

            //LinkedListNode val = AddTwoNumbersLeetCode.AddTwoNumbers(linkedList1.head ,linkedList2.head);
            int[] nums = new int[] { 0, 1, 0 };
            //LinkedListNode Node1 = LinkedListProblems.GetIntersectionNode(linkedList1.head, linkedList2.head);
            //if(Node1 != null)
            //{
            //    Console.WriteLine(Node1.Data);
            //}
            //else
            //{
            //    Console.WriteLine("null response");
            //}
            //bool output = RemoveDuplicatesLeetCode.IsPalindrome(10001);
            //int[] output = RemoveDuplicatesLeetCode.SearchRange2(nums,3);
            //foreach( int i in output )
            //{
            //    Console.WriteLine(i);
            //}

            //string haystack = "mississippi";
            //string needle = "issipi";

            //int outputVal = StringProblems.StrStr(haystack, needle);
            //Console.WriteLine(outputVal);
            //Console.WriteLine(output);
            //LinkedListNode node = LinkedListProblems.RemoveDuplicates(linkedList1.head);
            //LinkedList.PrintList(node);
            int[][] matrix = new int[][]
            {
            new int[] {0, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9},
            new int[] {12, 15, 19}
            };


            int[] values = new int[]{ 8, 4, 6, 2, 3 };
            // 4,6,10,16,22,24,2,3,2,3
            string[] values1 = new string[] { "d1/", "../", "../", "../" };
            ////string[] output1 = SortingProblems.SortPeople( values1, values);

            //int[] outputVal = SlidingWindow.Decrypt(values, -2);
            //foreach (int i in outputVal)
            //{
            //    Console.WriteLine(i);
            //}
            string sentence = "MuFoevIXCZzrpXeRmTssj lYSW U jM";
            int Val = SlidingWindow.NumOfSubarrays(values,3,5);
            //Console.WriteLine(Val);

            string input = "(()())(())(()(()))";
            // output ()()()()(())

            //string output = StackProblems.RemoveOuterParenthesesWOStack(input);
            //Console.WriteLine(output);



            int[] outputVal = StackProblems.FinalPrices(values);
            //foreach (int i in outputVal)
            //{
            //    Console.WriteLine(i);
            //}


            //int outputNum = StackProblems.MinOperations(values1);
            //Console.WriteLine(outputNum);


            //MinStack minStack = new MinStack();
            //Console.WriteLine(minStack.GetMin());
            //minStack.Push(-2);
            //minStack.Push(0);
            //minStack.Push(-1);


            //Console.WriteLine(minStack.GetMin()); // Output: -2
            //Console.WriteLine(minStack.Top());    // Output: -1

            //minStack.Pop();

            //Console.WriteLine(minStack.GetMin());

            //string homepage = "leetcode.com";
            //BrowserHistory browser = new BrowserHistory(homepage);
            //browser.Visit("google.com");
            //browser.Visit("facebook.com");
            //browser.Visit("youtube.com");
            //Console.WriteLine(browser.Back(1));
            //Console.WriteLine(browser.Back(1));
            //Console.WriteLine(browser.Forward(1));
            //browser.Visit("linkedin.com");
            //Console.WriteLine(browser.Forward(2));
            //Console.WriteLine(browser.Back(2));
            //Console.WriteLine(browser.Back(7));

            //int value = Recursion.nthFibonacci(2);
            long value = Recursion.nCrAlt(12, 13);
            //long value = Recursion.Factorial(12);
            Console.WriteLine(value);
        }
    }
}