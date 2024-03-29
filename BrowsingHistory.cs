//1472.Design Browser History
namespace LeetCode
{
    public class BrowserHistory
    {
        private DoublyLinkedListNode current;

        public BrowserHistory(string homepage)
        {
            current = new DoublyLinkedListNode(homepage);
        }

        public void Visit(string url)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode(url);
            current.Next = newNode;
            newNode.Prev = current;
            current = newNode;
        }

        public string Back(int steps)
        {
            while (steps > 0 && current.Prev != null)
            {
                current = current.Prev;
                steps--;
            }
            return current.Value;
        }

        public string Forward(int steps)
        {
            while (steps > 0 && current.Next != null)
            {
                current = current.Next;
                steps--;
            }
            return current.Value;
        }
    }
}
