public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0)
            return [];

        List<int[]> results = new List<int[]>();

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        results.Add(intervals[0]);

        for (int i = 1; i < intervals.Length ; i++) {
            var last = results.Count - 1;
            var intervalEnd = intervals[i][1];
            var intervalStar = intervals[i][0];
            var prevInterValEnd = results[last][1];

            if (intervalStar <= prevInterValEnd) {
                int mergedEnd = Math.Max(prevInterValEnd, intervalEnd);
                results[last][1] = mergedEnd;
            } else
                results.Add(intervals[i]);
        }

        return results.ToArray();
    }
}
