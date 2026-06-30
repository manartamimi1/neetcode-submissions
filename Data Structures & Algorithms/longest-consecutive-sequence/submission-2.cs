public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int maxLength = 0;

        foreach (int num in nums) {
            // Only start counting if this is the beginning of a sequence
            if (!set.Contains(num - 1)) {
                int currentNum = num;
                int currentLength = 1;

                while (set.Contains(currentNum + 1)) {
                    currentNum++;
                    currentLength++;
                }

                maxLength = Math.Max(maxLength, currentLength);
            }
        }

        return maxLength;
    }
}
