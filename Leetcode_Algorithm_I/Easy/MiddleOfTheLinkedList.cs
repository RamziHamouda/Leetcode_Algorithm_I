using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;

        }

        public static ListNode MiddleNode(ListNode head)
        {
            var length = 1;
            ListNode node = new ListNode(head.val, head.next);
            while (node.next != null)
            {
                length += 1;
                node = node.next;
            }

            node = new ListNode(head.val, head.next);
            for (var i = 1; i <= length / 2; i++)
            {
                node = node.next;
            }

            return node;
        }

        public static void test()
        {
            var listNode = new ListNode(5);
            var listNode2 = new ListNode(4, listNode);
            var listNode3 = new ListNode(3, listNode2);
            var listNode4 = new ListNode(2, listNode3);
            var listNode5 = new ListNode(1, listNode4);

            var result = MiddleNode(listNode5);

            Console.WriteLine("Result = {0}", result.val);
        }
    }
}
