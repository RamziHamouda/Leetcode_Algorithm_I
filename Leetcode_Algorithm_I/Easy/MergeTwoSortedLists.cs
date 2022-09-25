using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    public class MergeTwoSortedLists
    {
        public static ListNode MergeTwoSortedLists_Method(ListNode list1, ListNode list2)
        {
            var list = new List<int>();

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    list.Add(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    list.Add(list2.val);
                    list2 = list2.next;
                }
            }

            while (list1 != null)
            {
                list.Add(list1.val);
                list1 = list1.next;
            }

            while (list2 != null)
            {
                list.Add(list2.val);
                list2 = list2.next;
            }

            list.ForEach(x => Console.WriteLine(x));

            ListNode head = null;
            if (list.Count > 0) head = new ListNode();

            var result = head;

            for (int i = 0; i < list.Count; i++)
            {
                result.val = list[i];
                if (i != list.Count - 1)
                {
                    result.next = new ListNode();
                    result = result.next;
                }
            }

            // Be careful here: if the two lists are null, the result must be null
            // not new ListNode() because that will get back 0 (default of int)
            return head;
        }
    }
}


/*
 * var result = MergeTwoSortedLists.MergeTwoSortedLists_Method(null, null);

while(result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}
*/