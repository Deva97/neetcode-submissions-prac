public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> fre = new Dictionary<int, int>();

        foreach (var a in nums) {
            if (!fre.ContainsKey(a))
                fre[a] = 1;
                else fre[a] +=1;
        }

        foreach( var (key,value) in fre){
            Console.WriteLine(key +" " + value);
            if(value > 1){
                return true;
                
                
            }

            
        }

        return false;
    }
}