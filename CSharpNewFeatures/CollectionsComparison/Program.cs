// See https://aka.ms/new-console-template for more information

//IEnumerable, ICollection, IList, 
//ArrayList, IEnumerator, ReadOnlyCollection
//https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/guidelines-for-collections


using BenchmarkDotNet.Running;

//new Tests().TestUsingIEnumerable();
BenchmarkRunner.Run<Tests>();