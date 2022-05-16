public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 0;
        
        for (int i = digits.Length-1; i >= 0; i--)
        {
            if (i == digits.Length-1) digits[i] += 1;
            
            if(digits[i] + carry == 10)
            {
                carry = 1;
                digits[i] = 0;
            }
            else
            {
                digits[i] += carry;
                carry = 0;
            }
        }
        
        if (carry == 1)
        {
            var nums = new int[digits.Length+1];
            nums[0]=1;
            
            for (int i = 0; i <  digits.Length; i++)
            {
                nums[i+1] = digits[i];
            }
            
            return nums;
        }
        else
        {
            return digits;
        }
    }
}
