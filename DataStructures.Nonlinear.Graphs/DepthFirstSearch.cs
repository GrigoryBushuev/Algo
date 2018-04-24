using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Nonlinear.Graphs
{
    /// <summary>
    /// DFS is using the recursive approach to find whether a graphs nodes are connected 
    /// </summary>
    public class DepthFirstSearch<T>
    {
        private bool[] _visited;
        private int[] _edgesTo;
        private AdjacencyListGraph<T> _graph;
        private int _sourceVertexIndex;

        public DepthFirstSearch(AdjacencyListGraph<T> graph, int sourceVertexIndex)
        {
            _graph = graph;
            _sourceVertexIndex = sourceVertexIndex;
            _visited = new bool[graph.VertexesCount];
            _edgesTo = new int[graph.EdgesCount];
            Search(sourceVertexIndex);
        }

        private void Search(int fromVertexIndex)
        {
            _visited[fromVertexIndex] = true;
            foreach (var vertex in _graph.GetAdjacents(fromVertexIndex))
            {
                if (!_visited[vertex])
                {
                    _edgesTo[vertex] = fromVertexIndex;
                    Search(vertex);
                }
            }
        }

        public IEnumerable<int> GetPathTo(int toVertexIndex)
        {
            if (!_visited[toVertexIndex])
                return Enumerable.Empty<int>();

            var stack = new Stack<int>();
            for (var x = toVertexIndex; x != _sourceVertexIndex; x = _edgesTo[x])
            {
                stack.Push(x);
            }
            stack.Push(_sourceVertexIndex);
            return stack;
        } 
    }


}
