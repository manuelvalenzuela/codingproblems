using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems
{
    public class GraphNode
    {
        public GraphNode(string value)
        {
            Nodes = new List<GraphNode>();
            Value = value;
        }

        public string Value { get; set; }

        public List<GraphNode> Nodes { get; set; }

        public void InsertNode(GraphNode node)
        {
            if (Nodes.All(n => n.Value != node.Value))
            {
                Nodes.Add(node);
            }

            if (node.Nodes.All(n => n.Value != this.Value))
            {
                node.Nodes.Add(this);
            }
        }

        public void RemoveNode(string value)
        {
            var nodesToRemove = Nodes.Where(n => n.Value == value);
            foreach (var node in nodesToRemove)
            {
                node.Nodes.RemoveAll(n => n.Value == this.Value);
            }
            Nodes.RemoveAll(n => n.Value == value);
        }

        public void InsertNodes(List<GraphNode> nodes)
        {
            foreach (var node in nodes)
            {
                if (node != this)
                {
                    Nodes.Add(node);
                    node.Nodes.Add(this);
                }
            }
        }

        public void RemoveNodesPointingToThis()
        {
            foreach (var node in Nodes)
            {
                node.Nodes.RemoveAll(n => n.Value == this.Value);
            }
        }
    }
}