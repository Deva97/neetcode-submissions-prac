public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var temp = s[0] ^ t[0];
        for(int i = 1;i< s.Length; i++){
            temp = temp ^ s[i];
            temp = temp ^ t[i];
        }
        if(temp == 0) return true;
        return false;

    }
}
