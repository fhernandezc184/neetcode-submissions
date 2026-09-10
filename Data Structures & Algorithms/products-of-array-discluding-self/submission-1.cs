public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] answer = new int[nums.Length];

        var product = 1;

        for(var i = 0; i < nums.Length; i++){
            answer[i] = product;
            product *= nums[i];
        }

        product = 1;
        for(var i = nums.Length - 1; i >= 0 ; i--)
        {
            answer[i] *= product;
            product *= nums[i];
        }

        return answer;
    }
}
