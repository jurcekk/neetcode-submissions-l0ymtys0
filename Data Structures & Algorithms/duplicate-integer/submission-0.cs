public class Solution {
    public bool hasDuplicate(int[] nums) {
        var setA = new HashSet<int> {};

        for(int i = 0; i < nums.Length; i++) {
            if(setA.Contains(nums[i])) {
                return true;
            }
            setA.Add(nums[i]);
        }
        return false;
    }
}