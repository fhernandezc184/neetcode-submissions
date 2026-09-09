public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach(var word in strs)
        {
            var count = new int[26];

            foreach(var letter in word)
            {
                count[letter - 'a'] ++;
            }

            var key = string.Join(",", count);

            if(!groups.ContainsKey(key))
                groups[key] = new List<string>();
            
            groups[key].Add(word);
        }
        return groups.Values.ToList();
    }
}
