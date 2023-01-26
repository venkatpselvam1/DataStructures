// See https://aka.ms/new-console-template for more information

/* So far, we have seen:
    what is graph?
    What is uni-directed and bi-directed?
    What is connected graph?

In this section, we will have additionally cost on the edges of the graph.
We need to find, min cost that will take to traverse from (source)SRC to (destination)DEST.

 -> We will use adjacency list to represent the graph.
 -> We will first use DFS, BFS, Bellman Ford, Dijkstra and A* algo to solve the same problem

*/


/*
 
https://leetcode.com/problems/cheapest-flights-within-k-stops/description/
787. Cheapest Flights Within K Stops
 

There are n cities connected by some number of flights. You are given an array flights where flights[i] = [from-i, to-i, price-i] indicates that there is a flight from city fromi to city toi with cost pricei.

You are also given three integers src, dst, and k, return the cheapest price from src to dst with at most k stops. If there is no such route, return -1.

-------------------------------------------------------------------------------------------------
DFS:
-------------------------------------------------------------------------------------------------
We will use the DFS.
We will start from node 0 with cost 0 and stops 0,
for each adjacent node, we will explore them but with the condition
-> if the adjacent node is already visited with less stops and less cost we will not proceed furhter, we will return -1 which indicates that -> adjacent node can't be reached with current node.
-> we will use DynamicProgramming memoziation -> to store the min cost 
-------------------------------------------------------------------------------------------------

*/

public class Test
{
    public static void Main(String[] args)
    {
        System.Console.WriteLine("test");
    }
}