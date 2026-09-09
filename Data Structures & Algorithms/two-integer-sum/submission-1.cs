public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++){
            var compliment = target - nums[i];

            Console.WriteLine(compliment);
            if(seen.ContainsKey(nums[i]))
                return[seen[nums[i]], i];
            
            seen.Add(compliment, i);
        }
        return [];
    }
}
