public class Solution {
    public int FindDuplicate(int[] nums) {        
        HashSet<int> map = new HashSet<int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.Contains(nums[i]))
            {
                return nums[i];
            }
            
            map.Add(nums[i]);
        }
        
        return -1;
    }
}