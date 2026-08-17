class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    maxSlidingWindow(nums, k) {
        if (k === 1) return nums;

        let l = 0;
        let r = k - 1;
        let maxIndex = -1;

        const result = [];

        while (r < nums.length) {

            if (maxIndex < l || nums[maxIndex] <= nums[r]) {
                let tempMax = r;
                for (let i = r; i >= l; i--) {
                    if (nums[i] > nums[tempMax]) tempMax = i;
                }
                maxIndex = tempMax;
            }

            result.push(nums[maxIndex]);
            l++;
            r++;
        }

        return result;
    }
}
