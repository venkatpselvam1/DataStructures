﻿// See https://aka.ms/new-console-template for more information

using _004_DepthFirstSearch_AdjacencyList;

var graph = new Graph();
// Adding edges one by one 
graph.AddEdge(0, 1);
graph.AddEdge(0, 4);
graph.AddEdge(1, 2);
graph.AddEdge(1, 3);
graph.AddEdge(1, 4);
graph.AddEdge(2, 3);
graph.AddEdge(3, 4);
Console.WriteLine("DFS for 3");
graph.Dfs(3);