/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *      
   this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {

        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            // Save the next node
            ListNode next = current.next;

            // Reverse the pointer
            current.next = prev;

            // Move prev and current one step forward
            prev = current;
            current = next;
        }

        // prev is the new head
        return prev;
    }
}