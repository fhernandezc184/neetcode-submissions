class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums: number[], target: number): number[] {
        const data = new Map<number, number>();
        for (let i = 0; nums.length > i; i++){
            
            const complement = target - nums[i]
            const index = data.get(complement)

            if (index !== undefined){
                return [index, i]
            }
            data.set(nums[i], i)
        }
    }
}
