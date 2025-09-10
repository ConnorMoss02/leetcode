public class Solution
{
    public bool IsAnagram(string s, string t)
    {

        if (s.Length != t.Length) return false; // Quick check for length mismatch

        // Mapping letter -> occurences
        Dictionary<char, int> tracker = new Dictionary<char, int>();

        foreach (char letter in s)
        {
            if (tracker.ContainsKey(letter))
            {
                tracker[letter]++;
            }

            else
            {
                tracker[letter] = 1;
            }
        }

        foreach (char letter in t)
        {
            if (!tracker.ContainsKey(letter))
            {
                return false;
            }

            tracker[letter]--;

            if (tracker[letter] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
