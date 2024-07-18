namespace CSharpCodingQuestions;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [2, 11, 7, 15];
        int target = 9;
        var result = TwoSumProblem.TwoSumTwoPointer(nums, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}