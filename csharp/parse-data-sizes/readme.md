# Example usage

```csharp
Console.WriteLine(Helper.ParseDataSize("10MB")); // print 10485760
Console.WriteLine(Helper.ParseDataSize("10 MB ")); // print 10485760
Console.WriteLine(Helper.ParseDataSize(1024,"10 MB ")); // print 10485760
Console.WriteLine(Helper.ParseDataSize(1000,"10 MB ")); // print 10000000
Console.WriteLine(Helper.ParseDataSize("10MiB")); // print 10485760
Console.WriteLine(Helper.ParseDataSize("")); // print 0
Console.WriteLine(Helper.ParseDataSize("100")); // print 100
Console.WriteLine(Helper.ParseDataSize("1,2 GB")); // FormatException
Console.WriteLine(Helper.ParseDataSize("1.2 GB")); // print 1288490188
Console.WriteLine(Helper.ParseDataSize("1,2 GiB")); // print 1288490188
```