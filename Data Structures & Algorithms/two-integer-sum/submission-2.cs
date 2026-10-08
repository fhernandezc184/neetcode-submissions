public class Solution {
    public int[] TwoSum(int[] array, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (var i = 0; i < array.Length; i++) {
            var rest = target - array[i];

            if (map.TryGetValue(array[i], out int index))
                return [index, i];
            else
                map[rest] = i;
        }
        return [];
    }
}
