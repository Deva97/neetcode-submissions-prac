public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        if(s.Length == 1) return s[0] == t[0];
        int[] ans = new int[s.Length];
        for(int i =0;i<s.Length;i++){
            ans[i] = s[i] ^ t[i];
        }
        
        int temp = ans[0] ^ ans[1];
        for(int i =2;i<s.Length;i++){
            temp = temp^ ans[i];
        }

        if(temp == 0 ) return true; return false;

    }
}
