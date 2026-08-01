class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s: string): boolean {
        let right = s.length - 1;

        for (let i = 0; s.length > i; i++) {
            if (this.isAlphaNumeric(s[i])) {
                while (!this.isAlphaNumeric(s[right])) {
                    right--;
                }

                if (s[i].toLowerCase() !== s[right].toLowerCase()) return false;

                right -= 1;

                if (i >= right) return true;
            }
        }

        return true;
    }

    isAlphaNumeric(s: string): boolean {
        return (s >= "a" && s <= "z") || (s >= "A" && s <= "Z") || (s >= "0" && s <= "9");
    }
}
