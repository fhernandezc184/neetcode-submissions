class Solution {
    /**
     * @param {string} s
     * @return {number}
     */
    lengthOfLongestSubstring(s: string): number {

        let seen = new Set<string>()

        let longestSubstring = 0
        let startingPoint = 0
        if(!s)
            return 0

        for(let i = 0; i < s.length; i++){

            while(seen.has(s[i])){
                seen.delete(s[startingPoint])
                startingPoint++
            }
            
            seen.add(s[i])
            longestSubstring = Math.max(longestSubstring, i - startingPoint + 1)

        }
        return longestSubstring
    }
}
