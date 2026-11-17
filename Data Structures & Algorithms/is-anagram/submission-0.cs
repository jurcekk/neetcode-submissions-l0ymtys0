public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> wordS = new Dictionary<char,int>();
        Dictionary<char, int> wordT = new Dictionary<char,int>();

        if(s.Length != t.Length) {
            return false;
        }

        for(int i = 0; i < s.Length; i++) {
            if(wordS.ContainsKey(s[i])) {
                wordS[s[i]]++;
            } else {
            wordS.Add(s[i], 1);
            }
            
            if(wordT.ContainsKey(t[i])) {
                wordT[t[i]]++;
            } else {
            wordT.Add(t[i], 1);
            }

        }

        foreach(var pair in wordS) {
            if(wordT.GetValueOrDefault(pair.Key) != pair.Value) {
                return false;
            }
        }

        return true;
    }
}
