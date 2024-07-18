namespace CSharpCodingQuestions;

/* 2. Add Two Numbers
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. 
Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Example 2:
Input: l1 = [0], l2 = [0]
Output: [0]

Example 3:
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

*/

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

internal class AddTwoNumbersLinkedListProblem
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode(0);
        ListNode current = head;
        int carry = 0;

        while (l1 is not null || l2 is not null || carry > 0)
        {
            int sum = carry;

            if (l1 is not null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 is not null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
        }

        return head.next;

        /* 
           The code snippet contains a while loop that iterates through the linked lists 'l1' and 'l2' until both are null.
           The time complexity of this solution is O(max(m, n)) where m and n are the lengths of the linked lists 'l1' and 'l2' respectively.
        */
    }
}
