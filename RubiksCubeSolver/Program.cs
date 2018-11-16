using RubiksCubeSolver.Model;
using RubiksCubeSolver.Model.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
    class Program
    {
        static bool isSolved = false;
        static long numberOfStates = 0;
        static void Main(string[] args)
        {
            Cube cube = new Cube();
            int moves = 0;
            cube.LeftFace.Tiles = new TileColors[,]{
                { TileColors.Red, TileColors.Yellow },
                { TileColors.White,TileColors.Orange }
            };

            cube.RightFace.Tiles = new TileColors[,]
            {
                { TileColors.Red, TileColors.Orange},
                { TileColors.Red, TileColors.Yellow}
            };

            cube.FrontFace.Tiles = new TileColors[,]{
                { TileColors.Green, TileColors.White },
                { TileColors.White,TileColors.White }
            };

            cube.UpperFace.Tiles = new TileColors[,]{
                { TileColors.Green, TileColors.Yellow },
                { TileColors.Orange,TileColors.Blue }
            };

            cube.RearFace.Tiles = new TileColors[,]{
                { TileColors.Blue, TileColors.Yellow },
                { TileColors.Red,TileColors.Blue }
            };

            cube.BottomFace.Tiles = new TileColors[,]{
                { TileColors.Green, TileColors.Green },
                { TileColors.Orange,TileColors.Blue }
            };
            Node rootNode = new Node(cube, "", 0);

            PopulateTree(rootNode, moves);
            var a = 0;
        }

        public static void PopulateTree(Node node, int moves)
        {
            if (moves < 40 && !isSolved)
            {
                node.AddChild(node.State.ReverseRotateBottom(), "ReverseRotateBottom");
                node.AddChild(node.State.ReverseRotateFront(), "ReverseRotateFront");
                node.AddChild(node.State.ReverseRotateLeft(), "ReverseRotateLeft");
                node.AddChild(node.State.ReverseRotateRear(), "ReverseRotateRear");
                node.AddChild(node.State.ReverseRotateRight(), "ReverseRotateRight");
                node.AddChild(node.State.ReverseRotateUpper(), "ReverseRotateUpper");
                node.AddChild(node.State.RotateBottom(), "RotateBottom");
                node.AddChild(node.State.RotateFront(), "RotateFront");
                node.AddChild(node.State.RotateLeft(), "RotateLeft");
                node.AddChild(node.State.RotateRear(), "RotateRear");
                node.AddChild(node.State.RotateRight(), "RotateRight");
                node.AddChild(node.State.RotateUpper(), "RotateUpper");

                numberOfStates += 12;

                numberOfStates -= node.Children.RemoveAll(x => x.IsStatePresentInParentNodes() == true);
                Console.WriteLine(numberOfStates);

                isSolved = node.State.IsSolved();
                if (!node.State.IsSolved() && node.Children.Count > 0)
                {
                    foreach (Node child in node.Children)
                    {
                        //Console.WriteLine(child.Move);
                        PopulateTree(child, moves + 1);
                    }
                }
            }
        }
    }
}
