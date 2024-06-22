// See https://aka.ms/new-console-template for more information

using _001_FileSystemCopyPathOptimization;

var a = new List<string>()
{
    "c/a.txt",
    "c/b.txt",
    "c/d.txt",
    "c/e.txt",
    "c/f.txt",
    "d/b.txt",
    "d/e.txt",
    "d/f.txt",
    "d/g/b.txt",
    "d/g/e.txt",
    "d/h/b.txt",
    "d/h/e.txt",
};
var b = new List<string>()
{
    "c/b.txt",
    "c/e.txt",
    "c/f.txt",
    "d/b.txt",
    "d/e.txt",
    "d/f.txt",
    "d/g/b.txt",
    "d/g/e.txt",
    "d/h/b.txt",
    "d/h/e.txt",
};
var sln = new Solution();
var ans = sln.GetOptimizedFilePath(a, b);
Console.WriteLine("All files:");
Helper.print(a);
Console.WriteLine("-------------------------------------");
Console.WriteLine("Selected files:");
Helper.print(b);
Console.WriteLine("-------------------------------------");
Console.WriteLine("Simplied selected folders:");
Helper.print(ans);
Console.WriteLine("-------------------------------------");

