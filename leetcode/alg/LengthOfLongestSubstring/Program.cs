using System;
using System.Collections.Generic;

namespace LengthOfLongestSubstring
{

    public interface IProducable : IProducable<int>
    {
        
    }

    public interface IProducable<T> where T : IComparable<T>
    {

    }

    


    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "dvdf";
            var s2 = "ou";
            Console.WriteLine(LengthOfLongestSubstring(s1)); // 3
            Console.WriteLine(LengthOfLongestSubstring(s2)); // 1
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (s == "") return 0;

            var max = 1;
            var a = s.ToCharArray();
            var hs = new HashSet<char>();

            for (int i = 0; i < a.Length; i++)
            {
                var curr = 1;
                hs.Add(a[i]);
                for (int j = i+1; j < a.Length; j++)
                {
                    if(hs.Contains(a[j]))
                    {
                        hs.Clear();
                        break;

                    }
                    else
                    {
                        curr++;
                        hs.Add(a[j]);
                    }
                }

                if (curr > max) max = curr;
            } 
            return max;
        }
    }
}
