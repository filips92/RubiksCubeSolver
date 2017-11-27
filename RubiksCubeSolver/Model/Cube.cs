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
    }
}
