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

        public Cube RotateLeft()
        {
            Cube cube = this.Copy();
            var face = cube.LeftFace.Tiles;
            RotateFaceCounterClockwise(face);
            
            var frontFaceTopLeftTile = cube.FrontFace.Tiles[0, 0];
            var frontFaceBottomLeftTile = cube.FrontFace.Tiles[1, 0];

            cube.FrontFace.Tiles[0, 0] = cube.BottomFace.Tiles[0, 0];
            cube.FrontFace.Tiles[1, 0] = cube.BottomFace.Tiles[1, 0];

            cube.BottomFace.Tiles[0, 0] = cube.RearFace.Tiles[1, 1];
            cube.BottomFace.Tiles[1, 0] = cube.RearFace.Tiles[0, 1];

            cube.RearFace.Tiles[0, 1] = cube.UpperFace.Tiles[1, 0];
            cube.RearFace.Tiles[1, 1] = cube.UpperFace.Tiles[0, 0];

            cube.UpperFace.Tiles[0, 0] = frontFaceTopLeftTile;
            cube.UpperFace.Tiles[1, 0] = frontFaceBottomLeftTile;

            return cube;
        }

        public Cube ReverseRotateLeft()
        {
            Cube cube = this.Copy();
            var face = cube.LeftFace.Tiles;
            RotateFaceClockwise(face);

            var frontFaceTopLeftTile = cube.FrontFace.Tiles[0, 0];
            var frontFaceBottomLeftTile = cube.FrontFace.Tiles[1, 0];

            cube.FrontFace.Tiles[0, 0] = cube.UpperFace.Tiles[0, 0];
            cube.FrontFace.Tiles[1, 0] = cube.UpperFace.Tiles[1, 0];

            cube.UpperFace.Tiles[0, 0] = cube.RearFace.Tiles[1, 1];
            cube.UpperFace.Tiles[1, 0] = cube.RearFace.Tiles[0, 1];

            cube.RearFace.Tiles[0, 1] = cube.BottomFace.Tiles[1, 0];
            cube.RearFace.Tiles[1, 1] = cube.BottomFace.Tiles[0, 0];

            cube.BottomFace.Tiles[0, 0] = frontFaceTopLeftTile;
            cube.BottomFace.Tiles[1, 0] = frontFaceBottomLeftTile;

            return cube;
        }

        public Cube RotateRight()
        {
            Cube cube = this.Copy();
            var face = cube.RightFace.Tiles;
            RotateFaceClockwise(face);

            var frontFaceTopRightTile = cube.FrontFace.Tiles[0, 1];
            var frontFaceBottomRightTile = cube.FrontFace.Tiles[1, 1];

            cube.FrontFace.Tiles[0, 1] = cube.BottomFace.Tiles[0, 1];
            cube.FrontFace.Tiles[1, 1] = cube.BottomFace.Tiles[1, 1];

            cube.BottomFace.Tiles[0, 1] = cube.RearFace.Tiles[1, 0];
            cube.BottomFace.Tiles[1, 1] = cube.RearFace.Tiles[0, 0];

            cube.RearFace.Tiles[0, 0] = cube.UpperFace.Tiles[1, 1];
            cube.RearFace.Tiles[1, 0] = cube.UpperFace.Tiles[0, 1];

            cube.UpperFace.Tiles[0, 1] = frontFaceTopRightTile;
            cube.UpperFace.Tiles[1, 1] = frontFaceBottomRightTile;

            return cube;
        }

        public Cube ReverseRotateRight()
        {
            Cube cube = this.Copy();
            var face = cube.RightFace.Tiles;
            RotateFaceCounterClockwise(face);

            var frontFaceTopRightTile = cube.FrontFace.Tiles[0, 1];
            var frontFaceBottomRightTile = cube.FrontFace.Tiles[1, 1];

            cube.FrontFace.Tiles[0, 1] = cube.UpperFace.Tiles[0, 1];
            cube.FrontFace.Tiles[1, 1] = cube.UpperFace.Tiles[1, 1];

            cube.UpperFace.Tiles[0, 1] = cube.RearFace.Tiles[1, 0];
            cube.UpperFace.Tiles[1, 1] = cube.RearFace.Tiles[0, 0];

            cube.RearFace.Tiles[0, 0] = cube.BottomFace.Tiles[1, 1];
            cube.RearFace.Tiles[1, 0] = cube.BottomFace.Tiles[0, 1];

            cube.BottomFace.Tiles[0, 1] = frontFaceTopRightTile;
            cube.BottomFace.Tiles[1, 1] = frontFaceBottomRightTile;

            return cube;
        }

        public Cube RotateFront()
        {
            Cube cube = this.Copy();
            var face = cube.FrontFace.Tiles;
            RotateFaceClockwise(face);

            var leftFaceTopRightTile = cube.LeftFace.Tiles[0, 1];
            var leftFaceBottomRightTile = cube.LeftFace.Tiles[1, 1];

            cube.LeftFace.Tiles[0, 1] = cube.BottomFace.Tiles[0, 0];
            cube.LeftFace.Tiles[1, 1] = cube.BottomFace.Tiles[0, 1];

            cube.BottomFace.Tiles[0, 0] = cube.RightFace.Tiles[1, 0];
            cube.BottomFace.Tiles[0, 1] = cube.RightFace.Tiles[0, 0];

            cube.RightFace.Tiles[0, 0] = cube.UpperFace.Tiles[1, 0];
            cube.RightFace.Tiles[1, 0] = cube.UpperFace.Tiles[1, 1];

            cube.UpperFace.Tiles[1, 0] = leftFaceBottomRightTile;
            cube.UpperFace.Tiles[1, 1] = leftFaceTopRightTile;

            return cube;
        }

        public Cube ReverseRotateFront()
        {
            Cube cube = this.Copy();
            var face = cube.FrontFace.Tiles;
            RotateFaceCounterClockwise(face);

            var leftFaceTopRightTile = cube.LeftFace.Tiles[0, 1];
            var leftFaceBottomRightTile = cube.LeftFace.Tiles[1, 1];

            cube.LeftFace.Tiles[0, 1] = cube.UpperFace.Tiles[1, 1];
            cube.LeftFace.Tiles[1, 1] = cube.UpperFace.Tiles[1, 0];

            cube.UpperFace.Tiles[1, 0] = cube.RightFace.Tiles[0, 0];
            cube.UpperFace.Tiles[1, 1] = cube.RightFace.Tiles[1, 0];

            cube.RightFace.Tiles[0, 0] = cube.BottomFace.Tiles[0, 1];
            cube.RightFace.Tiles[1, 0] = cube.BottomFace.Tiles[0, 0];

            cube.BottomFace.Tiles[0, 0] = leftFaceTopRightTile;
            cube.BottomFace.Tiles[0, 1] = leftFaceBottomRightTile;

            return cube;
        }

        public Cube RotateRear()
        {
            Cube cube = this.Copy();
            var face = cube.RearFace.Tiles;
            RotateFaceClockwise(face);

            var rightFaceTopRightTile = cube.RightFace.Tiles[0, 1];
            var rightFaceBottomRightTile = cube.RightFace.Tiles[1, 1];

            cube.RightFace.Tiles[0, 1] = cube.BottomFace.Tiles[1, 1];
            cube.RightFace.Tiles[1, 1] = cube.BottomFace.Tiles[1, 0];

            cube.BottomFace.Tiles[1, 0] = cube.LeftFace.Tiles[0, 0];
            cube.BottomFace.Tiles[1, 1] = cube.LeftFace.Tiles[1, 0];

            cube.LeftFace.Tiles[0, 0] = cube.UpperFace.Tiles[0, 1];
            cube.LeftFace.Tiles[1, 0] = cube.UpperFace.Tiles[0, 0];

            cube.UpperFace.Tiles[0, 0] = rightFaceTopRightTile;
            cube.UpperFace.Tiles[0, 1] = rightFaceBottomRightTile;

            return cube;
        }

        public Cube ReverseRotateRear()
        {
            Cube cube = this.Copy();
            var face = cube.RearFace.Tiles;
            RotateFaceCounterClockwise(face);

            var rightFaceTopRightTile = cube.RightFace.Tiles[0, 1];
            var rightFaceBottomRightTile = cube.RightFace.Tiles[1, 1];

            cube.RightFace.Tiles[0, 1] = cube.UpperFace.Tiles[0, 0];
            cube.RightFace.Tiles[1, 1] = cube.UpperFace.Tiles[0, 1];

            cube.UpperFace.Tiles[0, 0] = cube.LeftFace.Tiles[1, 0];
            cube.UpperFace.Tiles[0, 1] = cube.LeftFace.Tiles[0, 0];

            cube.LeftFace.Tiles[0, 0] = cube.BottomFace.Tiles[1, 0];
            cube.LeftFace.Tiles[1, 0] = cube.BottomFace.Tiles[1, 1];

            cube.BottomFace.Tiles[1, 1] = rightFaceTopRightTile;
            cube.BottomFace.Tiles[1, 0] = rightFaceBottomRightTile;

            return cube;
        }

        public Cube RotateUpper()
        {
            Cube cube = this.Copy();
            var face = cube.UpperFace.Tiles;
            RotateFaceClockwise(face);

            var leftFaceTopLeftTile = cube.LeftFace.Tiles[0, 0];
            var leftFaceTopRightTile = cube.LeftFace.Tiles[0, 1];

            cube.LeftFace.Tiles[0, 0] = cube.FrontFace.Tiles[0, 0];
            cube.LeftFace.Tiles[0, 1] = cube.FrontFace.Tiles[0, 1];

            cube.FrontFace.Tiles[0, 0] = cube.RightFace.Tiles[0, 0];
            cube.FrontFace.Tiles[0, 1] = cube.RightFace.Tiles[0, 1];

            cube.RightFace.Tiles[0, 0] = cube.RearFace.Tiles[0, 0];
            cube.RightFace.Tiles[0, 1] = cube.RearFace.Tiles[0, 1];

            cube.RearFace.Tiles[0, 0] = leftFaceTopLeftTile;
            cube.RearFace.Tiles[0, 1] = leftFaceTopRightTile;

            return cube;
        }

        public Cube ReverseRotateUpper()
        {
            Cube cube = this.Copy();
            var face = cube.UpperFace.Tiles;
            RotateFaceCounterClockwise(face);

            var leftFaceTopLeftTile = cube.LeftFace.Tiles[0, 0];
            var leftFaceTopRightTile = cube.LeftFace.Tiles[0, 1];

            cube.LeftFace.Tiles[0, 0] = cube.RearFace.Tiles[0, 0];
            cube.LeftFace.Tiles[0, 1] = cube.RearFace.Tiles[0, 1];

            cube.RearFace.Tiles[0, 0] = cube.RightFace.Tiles[0, 0];
            cube.RearFace.Tiles[0, 1] = cube.RightFace.Tiles[0, 1];

            cube.RightFace.Tiles[0, 0] = cube.FrontFace.Tiles[0, 0];
            cube.RightFace.Tiles[0, 1] = cube.FrontFace.Tiles[0, 1];

            cube.FrontFace.Tiles[0, 0] = leftFaceTopLeftTile;
            cube.FrontFace.Tiles[0, 1] = leftFaceTopRightTile;

            return cube;
        }

        public Cube RotateBottom()
        {
            Cube cube = this.Copy();
            var face = cube.BottomFace.Tiles;
            RotateFaceClockwise(face);

            var leftFaceBottomLeftTile = cube.LeftFace.Tiles[1, 0];
            var leftFaceBottomRightTile = cube.LeftFace.Tiles[1, 1];

            cube.LeftFace.Tiles[1, 0] = cube.RearFace.Tiles[1, 0];
            cube.LeftFace.Tiles[1, 1] = cube.RearFace.Tiles[1, 1];

            cube.RearFace.Tiles[1, 0] = cube.RightFace.Tiles[1, 0];
            cube.RearFace.Tiles[1, 1] = cube.RightFace.Tiles[1, 1];

            cube.RightFace.Tiles[1, 0] = cube.FrontFace.Tiles[1, 0];
            cube.RightFace.Tiles[1, 1] = cube.FrontFace.Tiles[1, 1];

            cube.FrontFace.Tiles[1, 0] = leftFaceBottomLeftTile;
            cube.FrontFace.Tiles[1, 1] = leftFaceBottomRightTile;

            return cube;
        }

        public Cube ReverseRotateBottom()
        {
            Cube cube = this.Copy();
            var face = cube.BottomFace.Tiles;
            RotateFaceCounterClockwise(face);

            var leftFaceBottomLeftTile = cube.LeftFace.Tiles[1, 0];
            var leftFaceBottomRightTile = cube.LeftFace.Tiles[1, 1];

            cube.LeftFace.Tiles[1, 0] = cube.FrontFace.Tiles[1, 0];
            cube.LeftFace.Tiles[1, 1] = cube.FrontFace.Tiles[1, 1];

            cube.FrontFace.Tiles[1, 0] = cube.RightFace.Tiles[1, 0];
            cube.FrontFace.Tiles[1, 1] = cube.RightFace.Tiles[1, 1];

            cube.RightFace.Tiles[1, 0] = cube.RearFace.Tiles[1, 0];
            cube.RightFace.Tiles[1, 1] = cube.RearFace.Tiles[1, 1];

            cube.RearFace.Tiles[1, 0] = leftFaceBottomLeftTile;
            cube.RearFace.Tiles[1, 1] = leftFaceBottomRightTile;

            return cube;
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

        public Cube Copy()
        {
            return new Cube
            {
                LeftFace = LeftFace.Copy(),
                RightFace = RightFace.Copy(),
                FrontFace = FrontFace.Copy(),
                RearFace = RearFace.Copy(),
                UpperFace = UpperFace.Copy(),
                BottomFace = BottomFace.Copy()
            };
        }

        public bool IsSolved()
        {
            return
                (LeftFace.Tiles[0, 0] == LeftFace.Tiles[0, 1] && LeftFace.Tiles[0, 0] == LeftFace.Tiles[1, 0] && LeftFace.Tiles[0, 0] == LeftFace.Tiles[1, 1]) &&
                (RightFace.Tiles[0, 0] == RightFace.Tiles[0, 1] && RightFace.Tiles[0, 0] == RightFace.Tiles[1, 0] && RightFace.Tiles[0, 0] == RightFace.Tiles[1, 1]) &&
                (FrontFace.Tiles[0, 0] == FrontFace.Tiles[0, 1] && FrontFace.Tiles[0, 0] == FrontFace.Tiles[1, 0] && FrontFace.Tiles[0, 0] == FrontFace.Tiles[1, 1]) &&
                (RearFace.Tiles[0, 0] == RearFace.Tiles[0, 1] && RearFace.Tiles[0, 0] == RearFace.Tiles[1, 0] && RearFace.Tiles[0, 0] == RearFace.Tiles[1, 1]) &&
                (UpperFace.Tiles[0, 0] == UpperFace.Tiles[0, 1] && UpperFace.Tiles[0, 0] == UpperFace.Tiles[1, 0] && UpperFace.Tiles[0, 0] == UpperFace.Tiles[1, 1]) &&
                (BottomFace.Tiles[0, 0] == BottomFace.Tiles[0, 1] && BottomFace.Tiles[0, 0] == BottomFace.Tiles[1, 0] && BottomFace.Tiles[0, 0] == BottomFace.Tiles[1, 1]);
        }
    }
}
