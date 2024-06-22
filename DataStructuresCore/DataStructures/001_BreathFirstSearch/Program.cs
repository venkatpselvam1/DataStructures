// See https://aka.ms/new-console-template for more information

using _001_BreathFirstSearch;

var graph = new Graph(5);
graph.AddEdge(0, 1);
graph.AddEdge(2, 1);
graph.AddEdge(2, 3);
graph.AddEdge(4, 3);
graph.AddEdge(4, 0);
graph.AddEdge(4, 1);
graph.AddEdge(3, 1);
graph.Print();
graph.Bfs(4);