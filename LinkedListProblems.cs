namespace LeetCode
{
    public class LinkedListProblems
    {
        public static LinkedListNode GetIntersectionNode(LinkedListNode headA, LinkedListNode headB)
        {
            var tempA = headA;
            var tempB = headB;

            int listCountA = 1, listCountB = 1;

            while (tempA.Next != null || tempB.Next != null)
            {
                if (tempA.Next != null)
                {
                    listCountA++;
                    tempA = tempA.Next;
                }
                if (tempB.Next != null)
                {
                    listCountB++;
                    tempB = tempB.Next;
                }
            }

            tempA = headA; tempB = headB;
            for (int i = 0; i < Math.Abs(listCountA - listCountB); i++)
            {
                if (listCountA - listCountB > 0)
                    tempA = tempA.Next;
                else if (listCountA - listCountB < 0)
                    tempB = tempB.Next;
            }

            while (tempA != null || tempB != null)
            {
                if (tempA.Data == tempB.Data)
                    return tempA;
                tempA = tempA.Next;
                tempB = tempB.Next;
            }

            return null;
        }

        public static LinkedListNode GetIntersectionNodeApproach1(LinkedListNode headA, LinkedListNode headB)
        {
            LinkedListNode tempA = headA;
            LinkedListNode tempB = headB;
            while (tempA.Data != tempB.Data)
            {
                if (tempA.Next == null) tempA = headB;
                else tempA = tempA.Next;
                if (tempB.Next == null) tempB = headA;
                else tempB = tempB.Next;
            }
            return tempA;
        }

        public static LinkedListNode RemoveDuplicates(LinkedListNode head)
        {
            LinkedListNode temp = head;
            while(temp != null && temp.Next !=null)
            {
                if(temp.Data == temp.Next.Data)
                {
                    temp.Next = temp.Next.Next;
                }
                else
                {
                    temp = temp.Next;
                }
            }
            return head;
        }

    }
}
