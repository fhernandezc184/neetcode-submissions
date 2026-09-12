public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length == 1) return 1;

        if(nums.Length == 0) return 0;

        int answer = 1;
        HashSet<int> seen = new HashSet<int>(nums);

        foreach(int number in nums){
            if(!seen.Contains(number-1)){
                var count = 0;
                while(seen.Contains(number + count)){
                    count++;
                }
                answer = Math.Max(answer, count);
            }
        }
        return answer;
    }
}
