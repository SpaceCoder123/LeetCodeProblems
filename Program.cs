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
            int[] nums = new int[] { 1,2,3,3,3 };
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
            int[] output = RemoveDuplicatesLeetCode.SearchRange1(nums,3);
            foreach( int i in output )
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(output);
            //LinkedListNode node = LinkedListProblems.RemoveDuplicates(linkedList1.head);
            //LinkedList.PrintList(node);
        }
    }
}