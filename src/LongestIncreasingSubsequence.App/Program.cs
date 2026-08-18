using LongestIncreasingSubsequence;

Console.Write("Enter integers: ");

var input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input))
{
    var result = SequenceSolver.LongestIncreasingSubsequence(input);

    Console.WriteLine($"Longest increasing subsequence: {result}");
}
