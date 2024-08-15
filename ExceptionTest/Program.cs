using System.Diagnostics;

var sw = Stopwatch.StartNew();
for (var i = 0; i < 1000; i++)
{
    try
    {
        throw new Exception();
    }
    catch (Exception)
    {
    }
}
Console.WriteLine($"Done in {sw.Elapsed}");
