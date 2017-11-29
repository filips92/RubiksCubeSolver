using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.Model
{
    public class Cube
    {
        public Face LeftFace { get; set; }
        public Face RightFace { get; set; }
        public Face FrontFace { get; set; }
        public Face RearFace { get; set; }
        public Face UpperFace { get; set; }
        public Face BottomFace { get; set; }

        public Cube()
        {
            LeftFace = new Face();
            RightFace = new Face();
            FrontFace = new Face();
            UpperFace = new Face();
            RearFace = new Face();
            BottomFace = new Face();
        }

        public void RotateLeft()
        {
            var face = LeftFace.Tiles;
            RotateFaceCounterClockwise(face);
            
            var frontFaceTopLeftTile = FrontFace.Tiles[0, 0];
            var frontFaceBottomLeftTile = FrontFace.Tiles[1, 0];

            FrontFace.Tiles[0, 0] = BottomFace.Tiles[0, 0];
            FrontFace.Tiles[1, 0] = BottomFace.Tiles[1, 0];

            BottomFace.Tiles[0, 0] = RearFace.Tiles[1, 1];
            BottomFace.Tiles[1, 0] = RearFace.Tiles[0, 1];

            RearFace.Tiles[0, 1] = UpperFace.Tiles[1, 0];
            RearFace.Tiles[1, 1] = UpperFace.Tiles[0, 0];

            UpperFace.Tiles[0, 0] = frontFaceTopLeftTile;
            UpperFace.Tiles[1, 0] = frontFaceBottomLeftTile;
        }

        public void ReverseRotateLeft()
        {
            var face = LeftFace.Tiles;
            RotateFaceClockwise(face);

            var frontFaceTopLeftTile = FrontFace.Tiles[0, 0];
            var frontFaceBottomLeftTile = FrontFace.Tiles[1, 0];

            FrontFace.Tiles[0, 0] = UpperFace.Tiles[0, 0];
            FrontFace.Tiles[1, 0] = UpperFace.Tiles[1, 0];

            UpperFace.Tiles[0, 0] = RearFace.Tiles[1, 1];
            UpperFace.Tiles[1, 0] = RearFace.Tiles[0, 1];

            RearFace.Tiles[0, 1] = BottomFace.Tiles[1, 0];
            RearFace.Tiles[1, 1] = BottomFace.Tiles[0, 0];

            BottomFace.Tiles[0, 0] = frontFaceTopLeftTile;
            BottomFace.Tiles[1, 0] = frontFaceBottomLeftTile;
        }

        public void RotateRight()
        {
            var face = RightFace.Tiles;
            RotateFaceClockwise(face);

            var frontFaceTopRightTile = FrontFace.Tiles[0, 1];
            var frontFaceBottomRightTile = FrontFace.Tiles[1, 1];

            FrontFace.Tiles[0, 1] = BottomFace.Tiles[0, 1];
            FrontFace.Tiles[1, 1] = BottomFace.Tiles[1, 1];

            BottomFace.Tiles[0, 1] = RearFace.Tiles[1, 0];
            BottomFace.Tiles[1, 1] = RearFace.Tiles[0, 0];

            RearFace.Tiles[0, 0] = UpperFace.Tiles[1, 1];
            RearFace.Tiles[1, 0] = UpperFace.Tiles[0, 1];

            UpperFace.Tiles[0, 1] = frontFaceTopRightTile;
            UpperFace.Tiles[1, 1] = frontFaceBottomRightTile;
        }

        public void ReverseRotateRight()
        {
            var face = RightFace.Tiles;
            RotateFaceCounterClockwise(face);

            var frontFaceTopRightTile = FrontFace.Tiles[0, 1];
            var frontFaceBottomRightTile = FrontFace.Tiles[1, 1];

            FrontFace.Tiles[0, 1] = UpperFace.Tiles[0, 1];
            FrontFace.Tiles[1, 1] = UpperFace.Tiles[1, 1];

            UpperFace.Tiles[0, 1] = RearFace.Tiles[1, 0];
            UpperFace.Tiles[1, 1] = RearFace.Tiles[0, 0];

            RearFace.Tiles[0, 0] = BottomFace.Tiles[1, 1];
            RearFace.Tiles[1, 0] = BottomFace.Tiles[0, 1];

            BottomFace.Tiles[0, 1] = frontFaceTopRightTile;
            BottomFace.Tiles[1, 1] = frontFaceBottomRightTile;
        }

        public void RotateFront()
        {
            var face = FrontFace.Tiles;
            RotateFaceClockwise(face);

            var leftFaceTopRightTile = LeftFace.Tiles[0, 1];
            var leftFaceBottomRightTile = LeftFace.Tiles[1, 1];

            LeftFace.Tiles[0, 1] = BottomFace.Tiles[0, 0];
            LeftFace.Tiles[1, 1] = BottomFace.Tiles[0, 1];

            BottomFace.Tiles[0, 0] = RightFace.Tiles[1, 0];
            BottomFace.Tiles[0, 1] = RightFace.Tiles[0, 0];

            RightFace.Tiles[0, 0] = UpperFace.Tiles[1, 0];
            RightFace.Tiles[1, 0] = UpperFace.Tiles[1, 1];

            UpperFace.Tiles[1, 0] = leftFaceBottomRightTile;
            UpperFace.Tiles[1, 1] = leftFaceTopRightTile;
        }

        public void ReverseRotateFront()
        {
            var face = FrontFace.Tiles;
            RotateFaceCounterClockwise(face);

            var leftFaceTopRightTile = LeftFace.Tiles[0, 1];
            var leftFaceBottomRightTile = LeftFace.Tiles[1, 1];

            LeftFace.Tiles[0, 1] = UpperFace.Tiles[1, 1];
            LeftFace.Tiles[1, 1] = UpperFace.Tiles[1, 0];

            UpperFace.Tiles[1, 0] = RightFace.Tiles[0, 0];
            UpperFace.Tiles[1, 1] = RightFace.Tiles[1, 0];

            RightFace.Tiles[0, 0] = BottomFace.Tiles[0, 1];
            RightFace.Tiles[1, 0] = BottomFace.Tiles[0, 0];

            BottomFace.Tiles[0, 0] = leftFaceTopRightTile;
            BottomFace.Tiles[0, 1] = leftFaceBottomRightTile;
        }

        public void RotateRear()
        {
            var face = RearFace.Tiles;
            RotateFaceClockwise(face);

            var rightFaceTopRightTile = RightFace.Tiles[0, 1];
            var rightFaceBottomRightTile = RightFace.Tiles[1, 1];

            RightFace.Tiles[0, 1] = BottomFace.Tiles[1, 1];
            RightFace.Tiles[1, 1] = BottomFace.Tiles[1, 0];

            BottomFace.Tiles[1, 0] = LeftFace.Tiles[0, 0];
            BottomFace.Tiles[1, 1] = LeftFace.Tiles[1, 0];

            LeftFace.Tiles[0, 0] = UpperFace.Tiles[0, 1];
            LeftFace.Tiles[1, 0] = UpperFace.Tiles[0, 0];

            UpperFace.Tiles[0, 0] = rightFaceTopRightTile;
            UpperFace.Tiles[0, 1] = rightFaceBottomRightTile;
        }

        public void ReverseRotateRear()
        {
            var face = RearFace.Tiles;
            RotateFaceCounterClockwise(face);

            var rightFaceTopRightTile = RightFace.Tiles[0, 1];
            var rightFaceBottomRightTile = RightFace.Tiles[1, 1];

            RightFace.Tiles[0, 1] = UpperFace.Tiles[0, 0];
            RightFace.Tiles[1, 1] = UpperFace.Tiles[0, 1];

            UpperFace.Tiles[0, 0] = LeftFace.Tiles[1, 0];
            UpperFace.Tiles[0, 1] = LeftFace.Tiles[0, 0];

            LeftFace.Tiles[0, 0] = BottomFace.Tiles[1, 0];
            LeftFace.Tiles[1, 0] = BottomFace.Tiles[1, 1];

            BottomFace.Tiles[1, 1] = rightFaceTopRightTile;
            BottomFace.Tiles[1, 0] = rightFaceBottomRightTile;
        }

        public void RotateUpper()
        {
            var face = UpperFace.Tiles;
            RotateFaceClockwise(face);

            var leftFaceTopLeftTile = LeftFace.Tiles[0, 0];
            var leftFaceTopRightTile = LeftFace.Tiles[0, 1];

            LeftFace.Tiles[0, 0] = FrontFace.Tiles[0, 0];
            LeftFace.Tiles[0, 1] = FrontFace.Tiles[0, 1];

            FrontFace.Tiles[0, 0] = RightFace.Tiles[0, 0];
            FrontFace.Tiles[0, 1] = RightFace.Tiles[0, 1];

            RightFace.Tiles[0, 0] = RearFace.Tiles[0, 0];
            RightFace.Tiles[0, 1] = RearFace.Tiles[0, 1];

            RearFace.Tiles[0, 0] = leftFaceTopLeftTile;
            RearFace.Tiles[0, 1] = leftFaceTopRightTile;
        }

        public void ReverseRotateUpper()
        {
            var face = UpperFace.Tiles;
            RotateFaceCounterClockwise(face);

            var leftFaceTopLeftTile = LeftFace.Tiles[0, 0];
            var leftFaceTopRightTile = LeftFace.Tiles[0, 1];

            LeftFace.Tiles[0, 0] = RearFace.Tiles[0, 0];
            LeftFace.Tiles[0, 1] = RearFace.Tiles[0, 1];

            RearFace.Tiles[0, 0] = RightFace.Tiles[0, 0];
            RearFace.Tiles[0, 1] = RightFace.Tiles[0, 1];

            RightFace.Tiles[0, 0] = FrontFace.Tiles[0, 0];
            RightFace.Tiles[0, 1] = FrontFace.Tiles[0, 1];

            FrontFace.Tiles[0, 0] = leftFaceTopLeftTile;
            FrontFace.Tiles[0, 1] = leftFaceTopRightTile;
        }

        public void RotateBottom()
        {
            var face = BottomFace.Tiles;
            RotateFaceClockwise(face);

            var leftFaceBottomLeftTile = LeftFace.Tiles[1, 0];
            var leftFaceBottomRightTile = LeftFace.Tiles[1, 1];

            LeftFace.Tiles[1, 0] = RearFace.Tiles[1, 0];
            LeftFace.Tiles[1, 1] = RearFace.Tiles[1, 1];

            RearFace.Tiles[1, 0] = RightFace.Tiles[1, 0];
            RearFace.Tiles[1, 1] = RightFace.Tiles[1, 1];

            RightFace.Tiles[1, 0] = FrontFace.Tiles[1, 0];
            RightFace.Tiles[1, 1] = FrontFace.Tiles[1, 1];

            FrontFace.Tiles[1, 0] = leftFaceBottomLeftTile;
            FrontFace.Tiles[1, 1] = leftFaceBottomRightTile;
        }

        public void ReverseRotateBottom()
        {
            var face = BottomFace.Tiles;
            RotateFaceCounterClockwise(face);

            var leftFaceBottomLeftTile = LeftFace.Tiles[1, 0];
            var leftFaceBottomRightTile = LeftFace.Tiles[1, 1];

            LeftFace.Tiles[1, 0] = FrontFace.Tiles[1, 0];
            LeftFace.Tiles[1, 1] = FrontFace.Tiles[1, 1];

            FrontFace.Tiles[1, 0] = RightFace.Tiles[1, 0];
            FrontFace.Tiles[1, 1] = RightFace.Tiles[1, 1];

            RightFace.Tiles[1, 0] = RearFace.Tiles[1, 0];
            RightFace.Tiles[1, 1] = RearFace.Tiles[1, 1];

            RearFace.Tiles[1, 0] = leftFaceBottomLeftTile;
            RearFace.Tiles[1, 1] = leftFaceBottomRightTile;
        }

        private void RotateFaceClockwise(TileColors[,] face)
        {
            var temp = face[0, 0];
            face[0, 0] = face[1, 0];
            face[1, 0] = face[1, 1];
            face[1, 1] = face[0, 1];
            face[0, 1] = temp;
        }

        private void RotateFaceCounterClockwise(TileColors[,] face)
        {
            var temp = face[0, 0];
            face[0, 0] = face[0, 1];
            face[0, 1] = face[1, 1];
            face[1, 1] = face[1, 0];
            face[1, 0] = temp;
        }

        public bool Equals(Cube cube)
        {
            return (
                LeftFace.Equals(cube.LeftFace) &&
                RightFace.Equals(cube.RightFace) &&
                FrontFace.Equals(cube.FrontFace) &&
                RearFace.Equals(cube.RearFace) &&
                UpperFace.Equals(cube.UpperFace) &&
                BottomFace.Equals(cube.BottomFace)
            );
        }
    }
}
