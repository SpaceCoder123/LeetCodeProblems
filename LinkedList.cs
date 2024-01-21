namespace LeetCode
{
    public class LinkedList
    {
        public LinkedListNode head;

        public void AddNode(int data)
        {
            LinkedListNode newNode = new LinkedListNode(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                LinkedListNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public static void PrintList(LinkedListNode Node)
        {
            LinkedListNode current = Node;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
