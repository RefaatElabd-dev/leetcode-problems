// See https://aka.ms/new-console-template for more information
using problem1;
using System;

Console.WriteLine("Hello, World!");
foreach (var list in Solution.GroupThePeople(new int[] { 3, 3, 3, 3, 3, 1, 3 }))
{
	foreach (var item in list)
	{
		Console.Write(item + " ");
	}
	Console.WriteLine();
}

foreach (var list in Solution.GroupThePeople(new int[] { 2, 1, 3, 3, 3, 2 }))
{
    foreach (var item in list)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}