using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubiksCubeSolver.Model.Tree;
using RubiksCubeSolver.Model;

namespace RubiksCubeSolver.Tests
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void TestAddChildMethod()
        {
            Cube cube1 = new Cube()
            {
                BottomFace = new Face(TileColors.Blue),
                FrontFace = new Face(TileColors.Green),
                LeftFace = new Face(TileColors.Orange),
                RearFace = new Face(TileColors.Red),
                RightFace = new Face(TileColors.White),
                UpperFace = new Face(TileColors.Yellow)
            };
            Cube cube2 = new Cube()
            {
                BottomFace = new Face(TileColors.Green),
                FrontFace = new Face(TileColors.Blue),
                LeftFace = new Face(TileColors.Red),
                RearFace = new Face(TileColors.Orange),
                RightFace = new Face(TileColors.Yellow),
                UpperFace = new Face(TileColors.White)
            };

            Node rootNode = new Node(cube1, "", 0);
            rootNode.AddChild(cube2, "test");

            Assert.AreEqual("test", rootNode.Children[0].Move);
            Assert.IsTrue(rootNode.Children[0].ParentNode.State.Equals(cube1));
            Assert.IsTrue(rootNode.Children[0].State.Equals(cube2));
            Assert.AreEqual(1, rootNode.Children[0].Depth);
        }

        [TestMethod]
        public void TestIsStatePresentInParentNodes()
        {
            Cube state1 = new Cube
            {
                BottomFace = new Face(TileColors.Blue),
                FrontFace = new Face(TileColors.Blue),
                LeftFace = new Face(TileColors.Blue),
                RearFace = new Face(TileColors.Blue),
                RightFace = new Face(TileColors.Blue),
                UpperFace = new Face(TileColors.Blue)
            };

            Cube state2 = new Cube
            {
                BottomFace = new Face(TileColors.Blue),
                FrontFace = new Face(TileColors.Orange),
                LeftFace = new Face(TileColors.Yellow),
                RearFace = new Face(TileColors.Blue),
                RightFace = new Face(TileColors.Blue),
                UpperFace = new Face(TileColors.Blue)
            };

            Cube state3 = new Cube
            {
                BottomFace = new Face(TileColors.Yellow),
                FrontFace = new Face(TileColors.Blue),
                LeftFace = new Face(TileColors.Blue),
                RearFace = new Face(TileColors.Yellow),
                RightFace = new Face(TileColors.White),
                UpperFace = new Face(TileColors.Blue)
            };

            Node rootNode1 = new Node(state1, "", 0);
            rootNode1.AddChild(state2, "");
            rootNode1.Children[0].AddChild(state3, "");

            Node rootNode2 = new Node(state1, "", 0);
            rootNode2.AddChild(state2, "");
            rootNode2.Children[0].AddChild(state1, "");

            Node leaf1 = rootNode1.Children[0].Children[0];
            Node leaf2 = rootNode2.Children[0].Children[0];

            Assert.IsFalse(leaf1.IsStatePresentInParentNodes());
            Assert.IsTrue(leaf2.IsStatePresentInParentNodes());
        }
    }
}
