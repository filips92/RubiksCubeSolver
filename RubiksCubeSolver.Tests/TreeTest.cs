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

            Node rootNode = new Node(cube1, "");
            rootNode.AddChild(cube2, "test");

            Assert.AreEqual("test", rootNode.Children[0].Move);
            Assert.IsTrue(rootNode.Children[0].ParentNode.State.Equals(cube1));
            Assert.IsTrue(rootNode.Children[0].State.Equals(cube2));
        }
    }
}
