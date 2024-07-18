namespace CSharpCodingQuestions;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("C# Coding Questions");
            Console.WriteLine("====================");
            Console.WriteLine("1. Two Sum");
            Console.WriteLine("2. Add Two Numbers (Linked List)");
            Console.WriteLine("0. Exit");
            Console.Write("Please enter your choice (1/2/0): ");

            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    TwoSum();
                    break;
                case "2":
                    AddTwoNumbersLinkedList();
                    break;
                case "0":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    public static void TwoSum()
    {
        int[] nums = [2, 11, 7, 15];
        int target = 9;
        var result = TwoSumProblem.TwoSumTwoPointer(nums, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    public static void AddTwoNumbersLinkedList()
    {
        ListNode l1 = new(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new(5, new ListNode(6, new ListNode(4)));
        AddTwoNumbersLinkedListProblem addTwoNumbersLinkedList = new AddTwoNumbersLinkedListProblem();
        ListNode result = addTwoNumbersLinkedList.AddTwoNumbers(l1, l2);
        while (result is not null)
        {
            Console.Write($"{result.val} -> ");
            result = result.next;
        }
    }
}