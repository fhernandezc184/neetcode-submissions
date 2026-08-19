class Solution {
    /**
     * @param {number[]} temperatures
     * @return {number[]}
     */
    dailyTemperatures(temperatures) {
        
        let stack = []
        let n = temperatures.length
        let result = Array(n).fill(0)

        for(let i = 0; i < n; i++){

            while(
                stack.length &&
                temperatures[i] > stack[stack.length-1][0]
            )
            {
                let [, stackInd] = stack.pop();
                result[stackInd] = i - stackInd
            }

            stack.push([temperatures[i],i])
        }
        return result
    }
}
