class Solution {
    /**
     * @param {string} s
     * @param {number} k
     * @return {number}
     */
    characterReplacement(s: string, k: number): number {

        let frequencies = new Map<string, number>();

        let l = 0
        let maxf = 1
        let res = 0
        for(let r = 0; r < s.length; r++){

            if(frequencies.has(s[r])){
                console.log(s[r] + ' ' + r)
                frequencies.set(s[r], frequencies.get(s[r])+1)
                maxf = Math.max(maxf, frequencies.get(s[r]))
            }else{
                frequencies.set(s[r], 1)
            }

            while(r - l + 1 - maxf >  k){
                frequencies.set(s[l], frequencies.get(s[l])-1)
                l++
            }

            res = Math.max(res, r - l + 1);



        }

        return res
    }
}
