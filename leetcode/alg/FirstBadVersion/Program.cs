using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstBadVersion(5));

        }

        static bool IsBadVersion(int version)
        {
            return version == 4;
        }

        static int FirstBadVersion(int n)
        {
            return FirstBadVersionBetween(1, n);
        }

        static int FirstBadVersionBetween(int start, int end)
        {
            if (end - start == 1)
            {
                return IsBadVersion(start) ? start : end;
            }

            var middle = (end+start+1)/2;

            return IsBadVersion(middle) ?
                FirstBadVersionBetween(start, middle) :
                FirstBadVersionBetween(middle + 1, end); 
        }
    }
}
