using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CodingProblems
{
    public class MinCuts
    {
        private Dictionary<string, GraphNode> _nodes;

        public MinCuts()
        {
        }

        public int CountNodes()
        {
            return _nodes.Count;
        }

        public void Create(string[] lineNodes)
        {
            Initialize();

            foreach (var line in lineNodes)
            {
                var nodeStrValues = line.Split(" ");
                GraphNode first = null;
                foreach (var nodeStr in nodeStrValues)
                {
                    if (first == null)
                    {
                        first = GetOrCreateNode(nodeStr);
                    }
                    else
                    {
                        var node = GetOrCreateNode(nodeStr);
                        first.InsertNode(node);
                    }
                }
            }
        }

        public GraphNode GetNode(string value)
        {
            _nodes.TryGetValue(value, out var node);
            return node;
        }

        private int _joinedNodesStartIndex = 1000;

        public GraphNode Join(string first, string second)
        {
            var firstNode = GetNode(first);
            if (firstNode == null)
            {
                throw new ArgumentException();
            }

            var secondNode = GetNode(second);
            if (secondNode == null)
            {
                throw new ArgumentException();
            }

            var newNode = GetOrCreateNode($"{first}-{second}");

            firstNode.RemoveNodesPointingToThis();
            secondNode.RemoveNodesPointingToThis();

            RemoveNode(first, secondNode);
            RemoveNode(second, firstNode);

            newNode.InsertNodes(firstNode.Nodes);
            newNode.InsertNodes(secondNode.Nodes);

            return null;
        }

        public int RandomMinCuts()
        {
            while (_nodes.Count > 2)
            {
                var count = _nodes.Count();
                var rnd = new Random();
                var nodeIndex = rnd.Next(0, count);
                var firstNode = _nodes.ElementAt(nodeIndex).Value;
                var countChild = firstNode.Nodes.Count;
                var secondIndex = rnd.Next(0, countChild);
                var secondNode = _nodes.ElementAt(nodeIndex).Value.Nodes.ElementAt(secondIndex);
                Join(firstNode.Value, secondNode.Value);
            }

            return _nodes.First().Value.Nodes.Count();
        }

        private void RemoveNode(string value, GraphNode removeFrom)
        {
            removeFrom.RemoveNode(value);
            _nodes.Remove(value);
        }

        private void Initialize()
        {
            _nodes = new Dictionary<string, GraphNode>();
        }

        private GraphNode GetOrCreateNode(string value)
        {
            _nodes.TryGetValue(value, out var node);
            if (node != null) return node;
            node = new GraphNode(value);
            _nodes.Add(value, node);
            return node;
        }
    }
}