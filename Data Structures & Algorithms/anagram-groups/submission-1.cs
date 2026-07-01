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


    public List<List<string>> GroupAnagrams(string[] strs) {
        var ans = new List<List<string>>();
        for(int i =0;i<strs.Length;){
            var temp = new List<string>();
            var innerLst = new List<string>();
            innerLst.Add(strs[i]);
            for(int j=i+1;j<strs.Length;j++){
                if(IsAnagram(strs[i],strs[j]))
                    innerLst.Add(strs[j]);
                else
                    temp.Add(strs[j]);

            }
            ans.Add(innerLst);
            strs = temp.ToArray();
        }

        return ans;

    }
}
