public class Solution
{

    public string Encode(IList<string> strs)
    {
        var result = "";
        foreach (string s in strs)
        {
            result += s.Length + "#" + s;
        }

        return result;
    }

    public List<string> Decode(string s)
    {

        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));

            int start = j + 1;
            int end = start + length;

            result.Add(s.Substring(start, length));

            i = end;
        }

        return result;
    }
}
