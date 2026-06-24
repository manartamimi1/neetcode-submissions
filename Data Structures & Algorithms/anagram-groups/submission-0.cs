public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
      Dictionary<string,List<string>> strss = new   Dictionary<string,List<string>>();
        
        foreach( string word in strs ){
            char[] letters = word.ToCharArray();
            Array.Sort(letters);

            string key = new string(letters);
            if(!strss.ContainsKey(key)){
                 strss[key] = new List<string>();
                
            };
            
        strss[key].Add(word);

        }
        return strss.Values.ToList();

    }
}
