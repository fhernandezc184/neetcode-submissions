class Solution {
    /**
     * @param {string} s1
     * @param {string} s2
     * @return {boolean}
     */
    checkInclusion(s1: string, s2: string): boolean {
        if (!s1 || !s2) return false;
        let n = s1.length;

        // Create frequency map for s1
        const count = new Map<string, number>();
        for (let char of s1) {
            count.set(char, (count.get(char) || 0) + 1);
        }

        // Create a copy of the count map to track current window frequencies in s2
        let windowCount = new Map<string, number>();

        // Iterate over s2 with a fixed-size sliding window
        for (let r = 0; r < s2.length; r++) {
            const rightChar = s2[r];
            windowCount.set(rightChar, (windowCount.get(rightChar) || 0) + 1);

            if (r >= n) {
                // If the window size exceeds the length of s1, slide the window to the right
                const leftChar = s2[r - n];
                if (windowCount.get(leftChar)! === 1) {
                    windowCount.delete(leftChar);
                } else {
                    windowCount.set(leftChar, windowCount.get(leftChar)! - 1);
                }
            }

            // Compare the current window's character frequencies with that of s1
            if (r >= n - 1 && areMapsEqual(count, windowCount)) {
                return true;
            }
        }

        return false;

        // Helper function to check if two maps are equal
        function areMapsEqual(map1: Map<string, number>, map2: Map<string, number>): boolean {
            if (map1.size !== map2.size) return false;

            for (let [char, count] of map1) {
                if (map2.get(char)! !== count) return false;
            }

            return true;
        }
    }
}
