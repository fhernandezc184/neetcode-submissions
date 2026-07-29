class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums: number[]): boolean {
        let uniqueNumber = new Set<number>();
        for(let i = 0; nums.length > i; i++){
            if (uniqueNumber.has(nums[i]))
                return true
            uniqueNumber.add(nums[i])
        }
        return false
    }
}
