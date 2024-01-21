/// <summary>
/// 2. Add Two Numbers
/// You are given two non-empty linked lists representing two non-negative integers.
/// The digits are stored in reverse order, and each of their nodes contains a single digit.
/// Add the two numbers and return the sum as a linked list.
/// </summary>
/// <param name="l1">ListNode of first array.</param>
/// <param name="l2">ListNode of second array.</param>
/// <returns>The sum of the two arrays.</returns>

namespace LeetCode
{
    public class AddTwoNumbersLeetCode
    {
        public static LinkedListNode AddTwoNumbers(LinkedListNode node1, LinkedListNode node2)
        {
            LinkedListNode linkedListNode = new LinkedListNode(0);
            LinkedListNode temp = linkedListNode;
            int carryOver = 0;
            int target = 0;
            while(node1 != null || node2 != null)
            {
                if (node1 == null) target += 0;
                else
                {
                    target += node1.Data;
                    node1 = node1.Next;
                }
                if (node2 == null)
                {
                    target += carryOver;
                    if (target > 9)
                    {
                        carryOver = target / 10;
                        target = target % 10;
                    }
                    else
                    {
                        carryOver = 0;
                    }
                }
                else
                {
                    target += node2.Data;
                    if (carryOver > 0)
                    {
                        target = target+carryOver;
                        carryOver = 0;
                    }
                    if (target > 9)
                    {
                        carryOver = target / 10;
                        target = target % 10;
                    }
                    node2 = node2.Next;
                }

                temp.Next = new LinkedListNode(target);
                target = 0;
                temp = temp.Next;
            }
            if (carryOver > 0)
            {
                temp.Next = new LinkedListNode(carryOver);
            }
            LinkedList.PrintList(linkedListNode.Next);
            return linkedListNode.Next;
        }
        // better solution 
        public LinkedListNode addTwoNumbers(LinkedListNode l1, LinkedListNode l2)
        {
            LinkedListNode dummy = new LinkedListNode(0);
            LinkedListNode current = dummy;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.Data : 0;
                int y = (l2 != null) ? l2.Data : 0;
                int sum = x + y + carry;
                carry = sum / 10;
                current.Next = new LinkedListNode(sum % 10);

                if (l1 != null) l1 = l1.Next;
                if (l2 != null) l2 = l2.Next;
                current = current.Next;
            }

            if (carry > 0)
            {
                current.Next = new LinkedListNode(carry);
            }

            return dummy.Next;
        }
    }
}
