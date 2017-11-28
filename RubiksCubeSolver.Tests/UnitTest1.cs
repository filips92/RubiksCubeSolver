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
            Cube cube = GetMockCube();

            cube.RotateLeft();

            #region TESTS
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

            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestRotateRight()
        {
            Cube cube = GetMockCube();

            cube.RotateRight();

            #region TESTS
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Red, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestRotateFront()
        {
            Cube cube = GetMockCube();

            cube.RotateFront();

            #region TESTS
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Blue, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Red, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Green, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestRotateRear()
        {
            Cube cube = GetMockCube();

            cube.RotateRear();

            #region TESTS
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Green, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestRotateUpper()
        {
            Cube cube = GetMockCube();

            cube.RotateUpper();

            #region TESTS
            Assert.AreEqual(TileColors.Blue, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestRotateBottom()
        {
            Cube cube = GetMockCube();

            cube.RotateBottom();

            #region TESTS
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestReverseRotateLeft()
        {
            Cube cube = GetMockCube();

            cube.ReverseRotateLeft();

            #region TESTS
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Green, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestReverseRotateRight()
        {
            Cube cube = GetMockCube();

            cube.ReverseRotateRight();

            #region TESTS
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Red, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Green, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestReverseRotateFront()
        {
            Cube cube = GetMockCube();

            cube.ReverseRotateFront();

            #region TESTS
            Assert.AreEqual(TileColors.Green, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Green, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Red, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Yellow, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Blue, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestReverseRotateRear()
        {
            Cube cube = GetMockCube();

            cube.ReverseRotateRear();

            #region TESTS
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.White, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Red, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Yellow, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Blue, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestReverseRotateUpper()
        {
            Cube cube = GetMockCube();

            cube.ReverseRotateUpper();

            #region TESTS
            Assert.AreEqual(TileColors.Green, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        [TestMethod]
        public void TestReverseRotateBottom()
        {
            Cube cube = GetMockCube();

            cube.ReverseRotateBottom();

            #region TESTS
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RightFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.RightFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.RightFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.FrontFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.White, cube.FrontFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Red, cube.FrontFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.FrontFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.UpperFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.UpperFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Orange, cube.UpperFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Blue, cube.UpperFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Blue, cube.RearFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.RearFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.RearFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.RearFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Blue, cube.BottomFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.Green, cube.BottomFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.Orange, cube.BottomFace.Tiles[1, 1]);

            Assert.AreEqual(TileColors.Red, cube.LeftFace.Tiles[0, 0]);
            Assert.AreEqual(TileColors.Yellow, cube.LeftFace.Tiles[0, 1]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 0]);
            Assert.AreEqual(TileColors.White, cube.LeftFace.Tiles[1, 1]);
            #endregion
        }

        private Cube GetMockCube()
        {
            Cube cube = new Cube();

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
            return cube;
        }
    }
}
