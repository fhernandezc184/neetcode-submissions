class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums: number[]): number {
        if (nums.length === 0) return 0;

        let maxGlobal = 0;
        let currentMax = 1;

        nums = nums.sort((a, b) => a - b);

        console.log(nums);

        for (let i = 0; i <= nums.length - 1; i++) {
            if (nums[i + 1] === nums[i] + 1) {
                currentMax += 1;
            } else if (nums[i + 1] !== nums[i]) {
                maxGlobal = Math.max(maxGlobal, currentMax);
                currentMax = 1;
            }
        }
        maxGlobal = Math.max(maxGlobal, currentMax)

        return maxGlobal
    }
}
