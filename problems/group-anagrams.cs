public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {

        Dictionary<string, List<string>> hm = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            int[] arrayRep = new int[26];

            foreach (char letter in word)
            {
                arrayRep[letter - 'a']++;
            }

            string key = string.Join(",", arrayRep);

            if (!hm.ContainsKey(key))
            {
                hm[key] = new List<string>();
            }
            hm[key].Add(word);
        }

        return hm.Values.ToList();
    }
}
