public class Solution {

    public string Encode(IList<string> strs) {
        string encodedString = "";
		
		foreach(string word in strs){
			encodedString += word.Length + "#" + word;
		}
		return encodedString;
    }

    public List<string> Decode(string s) {
		
		List<string> answer = new List<string>();
		int i = 0;
		
		while(i < s.Length){
			int j = i;
			
			while(s[j] != '#'){
				j++;
			}
			
			int length = int.Parse(s.Substring(i, j -i));
			i = j + 1;
			j = i + length;
			
			answer.Add(s.Substring(i, length));
			i = j;
		}
		
		return answer;
	}
}
