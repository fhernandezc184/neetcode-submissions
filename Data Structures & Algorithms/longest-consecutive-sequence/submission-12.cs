public class Solution {
    public int LongestConsecutive(int[] nums) {

        int answer = 0;
        HashSet<int> seen = new HashSet<int>(nums);

        foreach(int number in nums){
            if(!seen.Contains(number-1)){
                var count = 1;
                while(seen.Contains(number + count)){
                    count++;
                }
                answer = Math.Max(answer, count);
            }
        }
        return answer;
    }
}
