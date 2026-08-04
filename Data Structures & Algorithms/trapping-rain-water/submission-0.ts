class Solution {
    /**
     * @param {number[]} height
     * @return {number}
     */
    trap(height: number[]): number {
        if(!height.length){
            return 0;
        }         
        let amountOfWater = 0
        let left = 0
        let right = height.length - 1 
        
        let leftMax = height[left]
        let rightMax = height[right]


        while(left < right){

            if(leftMax < rightMax){
                left++
                leftMax = Math.max(leftMax, height[left])
                amountOfWater += leftMax - height[left]
            }else{
                right--
                rightMax = Math.max(rightMax, height[right])
                amountOfWater += rightMax - height[right]
            }
        }

        return amountOfWater
    }
}
