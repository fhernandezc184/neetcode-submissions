public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length == 1) return 1;

        if(nums.Length == 0) return 0;

        int answer = 1;
        HashSet<int> seen = new HashSet<int>(nums);

        for(var i = 0; i < nums.Length; i++){
            if(!seen.Contains(nums[i]-1)){
                var count = 0;
                for(var j = 0; j < nums.Length; j++){
                    if(seen.Contains(nums[i] + count)){
                        count++;
                        answer = Math.Max(answer, count);
                    }
                }
            }
        }
        return answer;
    }
}
