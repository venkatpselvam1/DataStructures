using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _001_FileSystemCopyPathOptimization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * This coding question is asked in the google interview for me.
             * I was given list of all files in the OS
             * and I was also give list of selected files in the OS
             * When a all the files and folders inside a folder copied we can simply copy the path instead of the files
             * 
             * e.g:
             * we have a folder "a" and the folder have files "b.txt", "e.txt", "f.txt"
             * If the user selected the file "b.txt" we need to return ans as "a\b.txt"
             * if the user selected all the files("b.txt", "e.txt", "f.txt") we need to return ans as "a"
             * 
             * e.g 2:
             * we have a fodler "a" this folder have two folders "b","c" inside this. The folder "b" have file "b.txt" and the folder "c" have file "c.txt".
             * When the user selected both the files we need to return ans as "a"
             * because all the files in side the folder "b" and "c" selected which means all the folders inside the folder "a" also selected. so we can simple return "a"
             */
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
            var ans = GetOptimizedFilePath(a, b);
            Console.WriteLine("All files:");
            print(a);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Selected files:");
            print(b);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Simplied selected folders:");
            print(ans);
            Console.WriteLine("-------------------------------------");


        }
        private static void print(List<string> list)
        {
            foreach (var item in list) { Console.Write(item+","); }
            Console.WriteLine();
        }
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
        public static List<String>  GetOptimizedFilePath(List<String> allFiles, List<String> selectedFiles)
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
}
