using DataStructures.Nonlinear.Graphs;
using NUnit.Framework;
using System.Collections.Generic;

namespace DataStructures.Nonlinear.GraphTest
{
    [TestFixture]
    public class DepthFirstSearchTest
    {
        private AdjacencyListGraph<int> _graph;

        [SetUp]
        public void SetUp()
        {
            _graph = new AdjacencyListGraph<int>();
            _graph.AddVertex(0);
            _graph.AddVertex(1);
            _graph.AddVertex(2);
            _graph.AddVertex(3);
            _graph.AddVertex(4);
            _graph.AddVertex(5);
            _graph.AddVertex(6);
            _graph.AddVertex(7);
            _graph.AddVertex(8);
            _graph.AddVertex(9);
            _graph.AddVertex(10);
            _graph.AddVertex(11);
            _graph.AddVertex(12);

            _graph.AddEdge(0, 1);
            _graph.AddEdge(0, 2);
            _graph.AddEdge(0, 5);
            _graph.AddEdge(0, 6);
            _graph.AddEdge(3, 4);
            _graph.AddEdge(3, 5);
            _graph.AddEdge(4, 5);
            _graph.AddEdge(4, 6);
            _graph.AddEdge(7, 8);
            _graph.AddEdge(9, 10);
            _graph.AddEdge(9, 11);
            _graph.AddEdge(9, 12);
            _graph.AddEdge(11, 12);
        }

        [TestCase(0, 4, new int[] { 0, 5, 3, 4})]
        [TestCase(10, 4, new int[] { })]
        [TestCase(10, 12, new int[] { 10, 9, 11, 12})]
        public void GetPathTo_OnValidParameters_ReturnsExpectedResult(int fromVertexIndex, int toVertexIndex, IEnumerable<int> expectedPath)
        {
            //Arrange
            var dfs = new DepthFirstSearch<int>(_graph, fromVertexIndex);
            //Act
            var actualResult = dfs.GetPathTo(toVertexIndex);
            //Assert
            CollectionAssert.AreEqual(expectedPath, actualResult);
        }


    }
}
