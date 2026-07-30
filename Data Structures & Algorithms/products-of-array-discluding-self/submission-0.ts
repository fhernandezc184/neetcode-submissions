class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums: number[]): number[] {
        const numsLength = nums.length
        const answer: number[] = new Array(numsLength).fill(1)

        let leftProduct = 1;
        for(let i =0; i < numsLength; i++){
            answer[i] = leftProduct;
            leftProduct *= nums[i]
        }

        let rightProduct = 1
        for(let i = numsLength -1; i >= 0; i--){
            answer[i] *= rightProduct
            rightProduct *= nums[i]
        }

        return answer
    }
}
