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
            int output1 = BinarySearchProblems.FindPeakElement(nums);
            Console.WriteLine(output1);
        }
    }
}