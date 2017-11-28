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