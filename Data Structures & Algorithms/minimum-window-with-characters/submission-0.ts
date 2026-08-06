class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {string}
     */
    minWindow(s: string, t: string): string {
        let l = 0;
        let countT = new Map<string, number>();
        let have = 0;
        let resLen = Infinity;
        let resRange = [-1, -1];

        for (const c of t) countT.set(c, (countT.get(c) || 0) + 1);

        let need = countT.size;

        let windowCount = new Map<string, number>();

        for (let r = 0; r < s.length; r++) {
            if (countT.has(s[r])) {
                windowCount.set(s[r], (windowCount.get(s[r]) || 0) + 1);

                if (windowCount.get(s[r]) === countT.get(s[r])) have++;
            }
            while (have == need) {
                if (r - l + 1 < resLen) {
                    resLen = r - l + 1;
                    resRange = [l, r];
                }

                const charL = s[l];
                if (countT.has(charL)) {
                    windowCount.set(charL, windowCount.get(charL)! - 1);
                    if (windowCount.get(charL)! < countT.get(charL)!) {
                        have--;
                    }
                }
                l++;
            }
        }
        if (resLen === Infinity) {
            return "";
        } else {
            return s.substring(resRange[0], resRange[1] + 1);
        }
    }
}
