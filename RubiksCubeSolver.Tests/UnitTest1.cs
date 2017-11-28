using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubiksCubeSolver.Model;

namespace RubiksCubeSolver.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFaceConstructor()
        {
            Face testFace = new Face(TileColors.White);
            var tiles = testFace.Tiles;

            Assert.AreEqual(TileColors.White, tiles[0, 0]);
            Assert.AreEqual(TileColors.White, tiles[0, 1]);
            Assert.AreEqual(TileColors.White, tiles[1, 0]);
            Assert.AreEqual(TileColors.White, tiles[1, 1]);
        }

        [TestMethod]
        public void TestRotateLeft()
        {
            Cube cube = new Cube();

            cube.LeftFace = new Face();
            cube.FrontFace = new Face();
            cube.UpperFace = new Face();
            cube.RearFace = new Face();
            cube.BottomFace = new Face();

            cube.LeftFace.Tiles = new TileColors[,]{
                { TileColors.Red, TileColors.Yellow },
                { TileColors.White,TileColors.Orange }
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

            cube.RotateLeft();

            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Green, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Yellow, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 1]);
        }
    }
}
