namespace Leetcode_Algorithm_I{
    public class ReverseLinkedListClass{
        public ListNode ReverseLinkedList(ListNode head) {
        
        /*
        ListNode listNode = head;
        listNode = head.next;
        Console.WriteLine(head.val);
        Console.WriteLine(listNode.val);
        */
        
        if(head == null) return head;
        ListNode listNode = head;
        
        List<int> values = new List<int>();
        while(listNode != null){
            values.Add(listNode.val);
            listNode = listNode.next;
        }
        
        values.Reverse();
        
        ListNode headResult = new ListNode();
        ListNode result = headResult;
        
        for(var i = 0; i < values.Count; i++){
            result.val = values[i];
            if(i != values.Count - 1){
                result.next = new ListNode();
                result = result.next;
            }
        }
        
        return headResult;
    }
    }
}