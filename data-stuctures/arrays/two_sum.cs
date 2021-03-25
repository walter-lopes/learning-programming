//https://leetcode.com/problems/two-sum

// O (n^2) complexity
// O(1) space complexity

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i=0; i <= nums.Length; i++)
        {
            for(int j= i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[]{ i, j };
                }
            }
        }
        
        return new int[]{};      
    }
}

// O (n) complexity because we are using dictionary
// O(n) space complexity, cause number of items in the dict
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new  Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i ++)
        {
            if (map.ContainsKey(nums[i]))
            {
               map[nums[i]] = i;  
                continue;
            }
            map.Add(nums[i], i);
        }
        
        for(int i = 0; i < nums.Length; i ++)
        {
            int remain = target - nums[i];
            
            if (map.ContainsKey(remain) && map[remain] != i)
            {
                return new int[] {i, map[remain]};
            }
        }
        return new int[] {};
    }
}


// O (n) complexity because we are using dictionary
// O(n) space complexity, cause number of items in the dict
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new  Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i ++)
        {
            int remain = target - nums[i];
            
            if (map.ContainsKey(remain) && map[remain] != i)
            {
                return new int[] {i, map[remain]};
            }
            
            if (map.ContainsKey(nums[i]))
            {
               map[nums[i]] = i;  
                continue;
            }
            map.Add(nums[i], i);
        }
        return new int[] {};
    }
}