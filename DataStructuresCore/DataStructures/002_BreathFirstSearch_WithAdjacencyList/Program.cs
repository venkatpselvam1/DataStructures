// See https://aka.ms/new-console-template for more information

using _002_BreathFirstSearch_WithAdjacencyList;

var graph = new Graph();
// Adding edges one by one 
graph.AddEdge(0, 1);
graph.AddEdge(0, 4);
graph.AddEdge(1, 2);
graph.AddEdge(1, 3);
graph.AddEdge(1, 4);
graph.AddEdge(2, 3);
graph.AddEdge(3, 4);

graph.Bfs(4);