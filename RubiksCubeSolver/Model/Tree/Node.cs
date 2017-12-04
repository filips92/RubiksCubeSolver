using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.Model.Tree
{
    public class Node
    {
        public Node ParentNode { get; set; }
        public List<Node> Children { get; set; }
        public Cube State { get; set; }
        public string Move { get; set; }
        public int Depth { get; set; }

        public Node(Cube state, string move, int depth)
        {
            Children = new List<Node>();
            Move = move;
            State = state;
            Depth = depth;
        }

        public void AddChild(Cube state, string move)
        {
            Node child = new Node(state, move, Depth + 1)
            {
                ParentNode = this
            };
            Children.Add(child);
        }

        public bool IsStatePresentInParentNodes()
        {
            Node node = this;
            Cube currentState = node.State.Copy();
            while (node.ParentNode != null)
            {
                if (currentState.Equals(node.ParentNode.State))
                {
                    return true;
                }
                node = node.ParentNode;
            }
            return false;
        }
    }
}
