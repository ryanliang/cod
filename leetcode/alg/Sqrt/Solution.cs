public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        if (x == 1 || x == 2) return 1;
        
        for (int i = 0; i < x; i++)
        {
            if (i*i > x || i*i < 0) 
                return i-1;
        }
        
        return 0;
    }
}
