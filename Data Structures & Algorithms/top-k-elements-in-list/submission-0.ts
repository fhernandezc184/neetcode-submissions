class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums: number[], k: number): number[] {


        const count = new Map<number, number>();

        for(const n of nums){
            count.set(n, (count.get(n) || 0) + 1)
        }
        let sortedEntries: [number, number][] = Array.from(count.entries()).sort((a, b) => {
            return b[1] - a[1]
            });
        return sortedEntries.slice(0, k).map(entry => entry[0])
    }
}
