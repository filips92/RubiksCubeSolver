namespace RubiksCubeSolver.Model
{
    public class Face
    {
        public TileColors[,] Tiles { get; set; }
        public Face()
        {
            Tiles = new TileColors[2,2];
        }
        public Face(TileColors color)
        {
            Tiles = new TileColors[2, 2] { 
                { color, color }, 
                { color, color }
            };
        }

        public bool Equals(Face face)
        {
            return (
                Tiles[0, 0] == face.Tiles[0, 0] && 
                Tiles[0, 1] == face.Tiles[0, 1] && 
                Tiles[1, 0] == face.Tiles[1, 0] && 
                Tiles[1, 1] == face.Tiles[1, 1]
            );
        }

        public Face Copy()
        {
            Face returnFace = new Face();
            returnFace.Tiles[0, 0] = Tiles[0, 0];
            returnFace.Tiles[0, 1] = Tiles[0, 1];
            returnFace.Tiles[1, 0] = Tiles[1, 0];
            returnFace.Tiles[1, 1] = Tiles[1, 1];

            return returnFace;
        }
    }

    public enum TileColors
    {
        White,
        Yellow,
        Red,
        Orange,
        Blue,
        Green
    }
}