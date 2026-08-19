class Solution {
    /**
     * @param {number[]} temperatures
     * @return {number[]}
     */
    dailyTemperatures(temperatures: number[]): number[] {
        
        let n = temperatures.length;
        let result : number[] = Array(n).fill(0)
        let stack = []

        for(let i = 0; i < n; i++){
            let current = temperatures[i];
            
            while(stack.length && current > stack[stack.length-1][0]){
                const [, stackInd] = stack.pop();
                result[stackInd] = i - stackInd
            }
            stack.push([current, i])
        }

        return result
    }
}
