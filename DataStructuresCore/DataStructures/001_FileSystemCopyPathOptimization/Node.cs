namespace _001_FileSystemCopyPathOptimization;

public class Node
{
    public Dictionary<string, Node> Children = new Dictionary<string, Node>();
    public string Val;
    public bool Selected;
    public Node(string v)
    {
        this.Val = v;
    }
    public void Insert(string[] arr, int ind)
    {
        if(arr.Length - 1 == ind)
        {
            //this is a file
            var n = new Node(arr[ind]);
            this.Children.Add(arr[ind], n);
            return;
        }
        //this is a folder
        if (!Children.ContainsKey(arr[ind])) Children.Add(arr[ind], new Node(arr[ind]));
        Children[arr[ind]].Insert(arr, ind + 1);
    }
    public bool Select(string[] arr, int ind)
    {
        if (arr.Length - 1 == ind)
        {
            this.Children[arr[ind]].Selected = true;
        }
        else
        {
            var select = Children[arr[ind]].Select(arr, ind + 1);
            if (!select) return false;
        }

        foreach(var key in Children.Keys)
        {
            if (!Children[key].Selected) return false;
        }
        this.Selected = true;
        return true;
    }
    public void print()
    {
        Console.WriteLine(this.Val);
        foreach (var key in Children.Keys)
        {
            Children[key].print();
        }
    }
    public void dfs(List<String> list, string path, Node root)
    {
        if(this.Selected && this != root)
        {
            list.Add(path+"/"+this.Val);
            return;
        }
        foreach (var key in Children.Keys)
        {
            Children[key].dfs(list, this == root ? "" : path + "/" + this.Val, root);
        }
    }
}