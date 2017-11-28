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

        public void RotateLeft()
        {
            var face = LeftFace.Tiles;
            //rotate face
            var temp = face[0, 0];
            face[0, 0] = face[0, 1];
            face[0, 1] = face[1, 1];
            face[1, 1] = face[1, 0];
            face[1, 0] = temp;

            //TODO: swap adjacent pieces
            var tempFaceTile1 = FrontFace.Tiles[0,0];
            var tempFaceTile2 = FrontFace.Tiles[1,0];
            FrontFace.Tiles[0, 0] = BottomFace.Tiles[0, 0];
            FrontFace.Tiles[1, 0] = BottomFace.Tiles[1, 0];

            BottomFace.Tiles[0, 0] = RearFace.Tiles[1, 1];
            BottomFace.Tiles[1, 0] = RearFace.Tiles[0, 1];

            RearFace.Tiles[0, 1] = UpperFace.Tiles[1,0];
            RearFace.Tiles[1, 1] = UpperFace.Tiles[0,0];

            UpperFace.Tiles[0, 0] = tempFaceTile1;
            UpperFace.Tiles[1, 0] = tempFaceTile2;

        }
        public void RotateLeftPrime() { }

        public void RotateRight() { }
        public void RotateRightPrime() { }

        public void RotateFront() { }
        public void RotateFrontPrime() { }

        public void RotateRear() { }
        public void RotateRearPrime() { }

        public void RotateUpper() { }
        public void RotateUpperPrime() { }

        public void RotateBottom() { }
        public void RotateBottomPrime() { }
    }
}
