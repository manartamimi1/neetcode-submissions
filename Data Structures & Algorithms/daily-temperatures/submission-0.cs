public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stc = new Stack<int>();
        int[] result = new int[temperatures.Length];
         for(int i = 0 ; i < temperatures.Length ; i++){
            while(stc.Count > 0 && temperatures[i]> temperatures[stc.Peek()]){
                int prevIndex = stc.Pop();
                result[prevIndex] = i - prevIndex;
            }
           stc.Push(i);

        }
        return result;
    }
}
