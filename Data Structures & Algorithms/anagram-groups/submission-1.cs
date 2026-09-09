public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach(var s in strs){
            int[] count = new int[26];

            foreach(var c in s){
                count[c - 'a'] ++;
            }
            string key = String.Join(",", count);

            if(groups.ContainsKey(key)){
                groups[key].Add(s);
            }else{
                groups[key] = new List<string>();
                groups[key].Add(s);
            }
        }

        return groups.Values.ToList<List<string>>();
    }
}
