public class Solution {
    public int MaxArea(int[] heights) {

        var maxWater = 0;

        var l = 0;
        var r = heights.Length-1;

        while(l < r)
        {
            var lHeight = heights[l];
            var rHeight = heights[r]; 
            
            if( lHeight > rHeight)
            {
                maxWater = Math.Max(maxWater, (r - l) * rHeight);
                r--;
            }
            else
            {
                maxWater =  Math.Max(maxWater, (r - l) * lHeight);
                l++;
            }
        }

        return maxWater;

    }
}
