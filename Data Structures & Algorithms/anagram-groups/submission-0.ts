class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs: string[]): string[][] {
        const data = new Map<string,string[]>();

        for(const word of strs){
            const count = new Array(26).fill(0);
        
            for (const c of word){
                count[c.charCodeAt(0) - 97]++;
            }
            const key = count.join(",");

            if (!data.has(key)){
                data.set(key,[])
            }

            data.get(key)!.push(word)
        }

        return [...data.values()];
    }
}
