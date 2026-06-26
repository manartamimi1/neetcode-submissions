public class Solution {

    public string Encode(IList<string> strs) {
        string s = "";
     
        foreach(string word in strs){
           s += word.Length + "#" +word ;
        }
        return s;
    }

    public List<string> Decode(string s) {
        List<string> decodedStrings = new List<string>();
        int i = 0 ;
        while(i <s.Length){
        int j = i;
        while(s[j] != '#'){
            j++;
        }
             int length = int.Parse(s.Substring(i, j - i));

            // Move i after #
            i = j + 1;

            // Take exactly "length" characters
            string word = s.Substring(i, length);

            decodedStrings.Add(word);

            // Move i to the next encoded word
            i = i + length;
        }

      
        return decodedStrings;
   }
}
