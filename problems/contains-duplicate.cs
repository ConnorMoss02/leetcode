public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> hs = new HashSet<int>();
        foreach (int num in nums)
        {
            if (hs.Contains(num))
            {
                return true; // We found a duplicate
            }
            hs.Add(num); // If not, add the number to the set
        }

        return false;
    }
}