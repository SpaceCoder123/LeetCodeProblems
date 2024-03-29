namespace LeetCode
{
    public class DoublyLinkedListNode
    {
        public string Value { get; set; } = string.Empty;
        public DoublyLinkedListNode Prev;
        public DoublyLinkedListNode Next;

        public DoublyLinkedListNode(string value)
        {
            Value = value;
        }
    }
}