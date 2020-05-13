using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstBadVersion(10));

        }

        static bool IsBadVersion(int version)
        {
            return version >= 3;
        }

        static int FirstBadVersion(int n)
        {
            var start = 1;
            var end = n;

            while(start < end)
            {
                var mid = (start + end + 1) / 2;
                if(IsBadVersion(mid))
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }


    }
}
