public class Solution {
	public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> counter = new Dictionary<int ,int>();
        List<int>[] freq = new List<int>[nums.Length + 1];

        for(var i = 0; i < freq.Length; i++){
            freq[i] = new List<int>();
        }

        foreach(int number in nums){
            if(counter.ContainsKey(number)){
                counter[number] ++;
            }else
                counter.Add(number, 1);
        }

        foreach(var item in counter){
            freq[item.Value].Add(item.Key);
        }
		
		int indexCount = 0;
		var result = new int[k];
		for(var i = freq.Length - 1; i > 0 && indexCount != k; i--){
			foreach(var number in freq[i]){
                if (indexCount == k ) return result;
				result[indexCount] = number;
				indexCount++;
			}
		}
		
		return result;
    }
}
