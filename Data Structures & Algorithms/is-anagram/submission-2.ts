class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s: string, t: string): boolean {
       
        if (s.length !== t.length) {
            return false;
        }
       const charCounts = new Map<string, number>();


        for(let i = 0; i < s.length; i++){
            const char = s[i]
            charCounts.set(char, (charCounts.get(char) || 0) +1);
        }

        for(let i = 0; i < t.length; i++){
            const char  = t[i];

            const currentCount = charCounts.get(char) || 0;

            if(currentCount === 0){
                return false
            }

            charCounts.set(char, currentCount -1);
        }

        return true
    }
}
