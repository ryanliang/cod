public class Solution {
    public string AddBinary(string a, string b) {
        var result = new StringBuilder();
        if(a.Length >= b.Length)
        {
            b = new string('0', a.Length - b.Length) + b;
        }
        else
        {
            a = new string('0', b.Length - a.Length) + a;
        }
        
        int carry = 0;
        for (int i = a.Length-1; i >= 0; i--)
        {
            if (a[i] == '1' && b[i] == '1')
            {
                if(carry > 0)
                {
                    result.Insert(0, '1');
                    carry--;
                }
                else
                {
                    result.Insert(0, '0');
                }
                carry++;
            }
            else if(a[i] == '0' && b[i] == '0')
            {
                if(carry > 0)
                {
                    result.Insert(0, '1');
                    carry--;
                }
                else
                {
                    result.Insert(0, '0');
                }
            }
            else if(a[i] == '1' && b[i] == '0' || b[i] == '1' && a[i] == '0')
            {
                if(carry > 0)
                {
                    result.Insert(0, '0');
                }
                else
                {
                    result.Insert(0, '1');
                }
            }
        }
        
        if (carry > 0)
            return '1'+ result.ToString();
        else
            return  result.ToString();
    }
}
