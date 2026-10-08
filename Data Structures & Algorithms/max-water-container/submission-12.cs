public class Solution {
    public int MaxArea(int[] heights) {
        var maxWater = 0;

        var l = 0;
        var r = heights.Length - 1;

        while (l < r) {
            var lHeight = heights[l];
            var rHeight = heights[r];
            var min = Math.Min(rHeight, lHeight);
            maxWater = Math.Max(maxWater, (r - l) * min);

            if (lHeight > rHeight)
                r--;
            else
                l++;
        }

        return maxWater;
    }
}
