public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1 ;
        int Maxprofit = 0;
         while(right<prices.Length){
            if(prices[left]>prices[right]){
                left = right;
            }
            else {
                
                int profit = prices[right] - prices[left];
                 Maxprofit = Math.Max(profit,Maxprofit);
                 
            }
            right++;
          
        }
        return Maxprofit;
    }
}
