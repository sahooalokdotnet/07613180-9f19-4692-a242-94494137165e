namespace LongestIncreasingSubsequence;

public static class SequenceSolver
{
    public static string LongestIncreasingSubsequence(string input)
    {
int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

    if (nums.Length == 0)
        return "";

    int n = nums.Length;

    // dp[i] = length of the longest increasing subsequence
    // ending at index i
    int[] dp = new int[n];

    // previous[i] = previous index in the subsequence
    int[] previous = new int[n];

    Array.Fill(dp, 1);
    Array.Fill(previous, -1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (nums[j] < nums[i] && dp[j] + 1 > dp[i])
            {
                dp[i] = dp[j] + 1;
                previous[i] = j;
            }
        }
    }

    // index of the earliest subsequence with maximum length
    int maxLength = dp[0];
    int endIndex = 0;

    for (int i = 1; i < n; i++)
    {
        if (dp[i] > maxLength)
        {
            maxLength = dp[i];
            endIndex = i;
        }
    }

    // Reconstruct the subsequence
    List<int> result = new List<int>();

    while (endIndex != -1)
    {
        result.Add(nums[endIndex]);
        endIndex = previous[endIndex];
    }

    result.Reverse();

    return string.Join(" ", result);
    }
}
