namespace _001_FileSystemCopyPathOptimization;

public class Solution
{
    public List<String>  GetOptimizedFilePath(List<String> allFiles, List<String> selectedFiles)
    {
        var ans = new List<String>();
        var root = new Node("");
        foreach (var file in allFiles)
        {
            var arr = file.Split('/');
            root.Insert(arr, 0);
        }
        foreach (var file in selectedFiles)
        {
            var arr = file.Split('/');
            root.Select(arr, 0);
        }
        //root.print();
        root.dfs(ans, "", root);
        return ans;
    } 
}