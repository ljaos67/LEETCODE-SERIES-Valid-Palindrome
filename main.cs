using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) 
    {
        s = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", String.Empty);
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != s[s.Length - i - 1])
            {
                return false;
            }
        }
        return true;          
    }
}
