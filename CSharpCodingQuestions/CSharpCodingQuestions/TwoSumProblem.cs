namespace CSharpCodingQuestions;

/*1. Two Sum
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order. 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 
*/

internal class TwoSumProblem
{
    public static int[] TwoSumBruteForce(int[] nums, int target)
    {
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return [];

        /* 
           The code snippet contains a nested for loop where the outer loop iterates through the 'nums' array once 
           and the inner loop iterates through the 'nums' array again.
           This results in a time complexity of O(n^2) where n is the length of the 'nums' array. 
        */
    }

    public static int[] TwoSumDictionary(int[] nums, int target) 
    { 
        
        var dictonary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(dictonary.TryGetValue(complement, out int value)) {
                return [value, i];
            }
            dictonary[nums[i]] = i;
        }

        return [];

        /* 
           The code snippet contains a single for loop that iterates through the 'nums' array once. 
           In each iteration, it checks if the complement of the current element exists in the dictionary. 
           If it does, it returns the indices of the two numbers that add up to the target. 
           If not, it adds the current element and its index to the dictionary. 
           This results in a time complexity of O(n) where n is the length of the 'nums' array. 
        */
    }

    public static int[] TwoSumTwoPointer(int[] nums, int target) 
    {

        (int num, int index)[] numbers = nums.Select((num, index) => (num, index)).ToArray();

        Array.Sort(numbers, (a, b) => a.num.CompareTo(b.num));

        int i = 0, j = nums.Length - 1;

        while (i < j)
        {
            int sum = numbers[i].num + numbers[j].num;
            if (sum == target)
            {
                return [numbers[i].index, numbers[j].index];
            }
            else if (sum < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return [];
    }
}
