using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleAppCSharp.Algorithm
{
    internal class Djikstra
    {

        static int V = 9;

        public void djikstraAlgo()
        {
            Console.WriteLine("check Djikstra Algo");

            var graph = new List<List<int>>();
            graph.Add( new List<int> { 0, 4, 0, 0, 0, 0, 0, 8, 0 } );

            graph.Add( new List<int> { 4, 0, 8, 0, 0, 0, 0, 11, 0 } );
            graph.Add( new List<int> { 0, 8, 0, 7, 0, 4, 0, 0, 2 } );
            graph.Add( new List<int> { 0, 0, 7, 0, 9, 14, 0, 0, 0 } );
            graph.Add( new List<int> { 0, 0, 0, 9, 0, 10, 0, 0, 0 } );
            graph.Add( new List<int> { 0, 0, 4, 14, 10, 0, 2, 0, 0 } );
            graph.Add( new List<int> { 0, 0, 0, 0, 0, 2, 0, 1, 6 } );
            graph.Add( new List<int> { 8, 11, 0, 0, 0, 0, 1, 0, 7 } );

            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    Console.Write(graph[i][j] + " ");
                }
                Console.WriteLine();
            }

            if (graph.Count != V)
            {
                Console.WriteLine("Graph size mismatch!");
                return;
            }

            learnThread();

        }

        public static void learnThread()
        {
            Thread backgroundThread = new Thread(new ThreadStart(Algorithm.Djikstra.heavyLifting));
            
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
            Console.WriteLine("Main thread is doing some work...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread working...");
                Thread.Sleep(500);
            }
            backgroundThread.Join();

        }

        public static void heavyLifting()
        {
            Console.WriteLine("I'm lifting a truck!!!");
            Thread.Sleep(1000);
        }
    }
}
