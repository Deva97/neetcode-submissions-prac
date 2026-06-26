public class Solution {
    public bool IsAnagram(string s, string t) {
        var fre = new Dictionary<char,int>();
        foreach(var a in s)
        {
            if(!fre.ContainsKey(a))
                fre[a] = 1;
            else
            fre[a] +=1;
        }

        foreach(var a in t)
        {
            if(!fre.ContainsKey(a))
                return false;
            else
            fre[a] -=1;
        }

        foreach(var(key,value) in fre){
            if(value!=0)
                return false;
        }

        return true;


    }
}
