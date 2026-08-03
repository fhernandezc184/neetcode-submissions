class Solution {
    /**
     * @param {number[]} heights
     * @return {number}
     */
    maxArea(heights: number[]): number {
        let maximumOfWater = 0

        let l = 0
        let r = heights.length - 1

        while(l < r){
            let lowerFromLandR = Math.min(heights[l], heights[r])
            let calculateMaximunOfWater = lowerFromLandR * (r - l) 
            maximumOfWater = Math.max(maximumOfWater, calculateMaximunOfWater)

            if(heights[l] > heights[r]){
                r--
            }else{
                l++
            }
        }

        return maximumOfWater
    }
    
}
