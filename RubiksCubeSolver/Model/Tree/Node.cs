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
        public string Move { get; set; }
        public Cube State { get; set; }

        public Node(Cube state, string move)
        {
            Children = new List<Node>();
            Move = move;
            State = state;
        }

        public void AddChild(Cube state, string move)
        {
            Node child = new Node(state, move)
            {
                ParentNode = this
            };
            Children.Add(child);
        }
    }
}
