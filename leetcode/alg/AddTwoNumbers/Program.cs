using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 342
            var l3 = new ListNode(1, null);
            var l2 = new ListNode(8, l3);

            // 465
            var n3 = new ListNode(0, null);

            // 342  + 465 = 807
            Console.Write(AddTwoNumbers(l2, n3).ToString());
        }

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if(l1 == null || l2 == null) throw new ArgumentException();

            var curr1 = l1;
            var curr2 = l2;


            var nodes = new List<ListNode>();
            while (curr1?.next != null || curr2?.next != null)
            {
                var sum = (curr1?.val ?? 0) + (curr2?.val ?? 0);
                var newNode = new ListNode(sum, null);
                nodes.Add(newNode);
                curr1 = curr1?.next;
                curr2 = curr2?.next;
            }

            var sum2 = (curr1?.val ?? 0) + (curr2?.val ?? 0);
            var newNode2 = new ListNode(sum2, null);
            nodes.Add(newNode2);
            return MakeList(nodes);
        }

        static ListNode MakeList(List<ListNode> nodes)
        {
            for(var i = 0; i < nodes.Count; i++)
            {
                var curr = nodes[i];
                if (i<nodes.Count-1)
                {
                    curr.next=nodes[i+1];

                    if(curr.val >= 10)
                    {
                        curr.val -= 10;
                        curr.next.val++;
                    }
                }
                else
                {
                    if (curr.val>=10)
                    {
                        curr.val -= 10;
                        curr.next=new ListNode(1, null);
                    }
                }
            }

            return nodes[0];
        }

        class ListNode
        {
            public ListNode(int val, ListNode next)
            {
                this.val = val;
                this.next = next;
            }

            public int val;

            public ListNode next;

            public override string ToString()
            {
                if (next == null)
                {
                    return val.ToString();
                }

                return $"{val} => {next.ToString()}";
            }
        }

    }
}
