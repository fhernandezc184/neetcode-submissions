class Solution {
    /**
     * @param {number[]} prices
     * @return {number}
     */
    maxProfit(prices: number[]): number {

        let indexBuyDay = 0
        
        let sellingFor = 0
        let buyingFor = prices[0]
        let globalProfit = 0

        for(let i = 0; i < prices.length; i++){
            
            let currentProfit = prices[i] - prices[indexBuyDay]
            console.log(currentProfit)
            globalProfit = Math.max(globalProfit , currentProfit)

            if(prices[indexBuyDay] > prices[i]){
                indexBuyDay = i
            }
            
        }



        return globalProfit
    }
}
