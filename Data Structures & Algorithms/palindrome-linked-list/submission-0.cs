/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;

        while(fast != null && fast.next!=null){
            slow = slow.next;
            fast = fast.next.next;

        
        }
        ListNode current = slow;
        ListNode prev = null;
        while(current != null){
          ListNode next= current.next;

          current.next = prev;

          prev = current;
          current = next;
        }
        ListNode first = head;
        ListNode second = prev;

        while(second !=null){
         if(first.val != second.val){
            return false;
         }
         first = first.next;
         second = second.next;
        
        }
        return true;


        
    }

}