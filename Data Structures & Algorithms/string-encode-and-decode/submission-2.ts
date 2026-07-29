class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs: string[]): string {
        let wordslength: number[] = [];
        let fullstring: string = "";
        for (const str of strs) {
            wordslength.push(str.length);
            fullstring += str;
        }
        let encodeString = wordslength.join(",") + "#@#" + fullstring;
        return encodeString;
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str: string): string[] {
        var d = str.indexOf("#@#");
        var e = str.substring(d + 3);
        var x = str.substring(0, d);
        if (x === "") return [];
        var xList = x.split(",");

        var lastIndexUsed = 0;
        let words: string[] = [];

        for (const r of xList) {
            let wordLength = Number(r);

            words.push(e.substring(lastIndexUsed, lastIndexUsed + wordLength));
            lastIndexUsed += wordLength;
        }
        return words
    }
}