public class Solution {
    public bool IsValid(string s) {
        Stack<char> openBrackets = new Stack<char>();

        for(int i = 0; i < s.Length ; i++) {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[') {
                openBrackets.Push(s[i]);
            }
            else if((s[i] == ')' || s[i] == '}' || s[i] == ']')) {
                if (openBrackets.Count == 0) return false;
                char lastOpenBracket = openBrackets.Pop();
                string matchingPair = "" + lastOpenBracket + s[i];
                if(matchingPair != "()" && matchingPair != "{}" && matchingPair != "[]"){
                    return false;
                }
            }
        }
        return openBrackets.Count == 0;
    }
}
