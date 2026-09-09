public class Solution {
    public bool IsAnagram(string s, string t) {
        

        if (s.Length != t.Length) return false;
        
        Dictionary<char, int> seen = new Dictionary<char, int>();
        foreach(char letter in s){

            if(seen.ContainsKey(letter)) 
                seen[letter] += 1;
            else
                seen.Add(letter, 1);
        }

        foreach(char letter in t){

            if(seen.ContainsKey(letter)){
                seen[letter] -= 1;

                if(seen[letter] == 0)
                    seen.Remove(letter);
            }
            else
                return false;
        }

        return true;
    }
}
