public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var freq = new Dictionary<int,int>();

        for(int i =0;i<nums.Length;i++){
            var temp = target - nums[i];
            if(freq.ContainsKey(temp))
                return new int[2] {freq[temp],i};
            freq[nums[i]] = i; 
                        }

                    return new int[2];
    }
}
