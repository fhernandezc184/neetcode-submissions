class Solution {
    /**
     * @param {string[]} tokens
     * @return {number}
     */
    evalRPN(tokens: string[]): number {
        const stack: number[] = [];

        for (const token of tokens) {
            if (!isNaN(Number(token))) {
                stack.push(Number(token));
                continue;
            }

            const b = stack.pop()!;
            const a = stack.pop()!;

            switch (token) {
                case "+":
                    stack.push(a + b);
                    break;
                case "-":
                    stack.push(a - b);
                    break;
                case "*":
                    stack.push(a * b);
                    break;
                case "/":
                    stack.push(Math.trunc(a / b));
                    break;
            }
        }

        return stack[0];
    }
}
