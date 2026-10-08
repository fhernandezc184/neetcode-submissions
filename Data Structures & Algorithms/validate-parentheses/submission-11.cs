public class Solution {
    public bool IsValid(string s) {

        if(s.Length < 2) return false;

        var stack = new Stack<char>();

        foreach(var c in s)
        {
            if(c == '(' || c == '{' || c == '[') 
                stack.Push(c);
            else
            {
                if(stack.Count == 0) return false;
                
                if(stack.Count > 0)
                {
                    var openParen = stack.Pop();
                
                    if(c == '}' && openParen != '{') return false;
                    
                    if(c == ')' && openParen != '(') return false;
                   
                    if(c == ']' && openParen != '[') return false;   
                }


            }

        }

        return stack.Count == 0;
    }
}
