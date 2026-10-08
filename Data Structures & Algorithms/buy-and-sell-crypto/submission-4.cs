public class Solution {
    public int MaxProfit(int[] prices) {
        var buy = 0;
        var maxProfit = 0;

        for (int sell = 0; sell < prices.Length; sell++) {
            while (prices[buy] > prices[sell] && buy < sell) {
                buy++;
            }
            maxProfit = Math.Max(maxProfit, prices[sell] - prices[buy]);
        }

        return maxProfit;
    }
}
