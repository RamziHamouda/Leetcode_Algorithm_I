// See https://aka.ms/new-console-template for more information
using Leetcode_Algorithm_I;
using Leetcode_Algorithm_I.Easy;
using Leetcode_Algorithm_I.Medium;
using System.Linq;

Console.WriteLine("Hello, World!");

var result = MergeTwoSortedLists.MergeTwoSortedLists_Method(null, null);

while(result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}

Console.WriteLine("Result = /n");


