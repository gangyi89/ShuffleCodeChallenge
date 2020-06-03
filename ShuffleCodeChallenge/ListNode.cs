using System;
namespace ShuffleCodeChallenge
{
    public class ListNode
    {

        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int x)
        {
            Value = x;
            Next = null;
        }
    }
}
