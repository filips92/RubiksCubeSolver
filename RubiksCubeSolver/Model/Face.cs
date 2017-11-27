namespace RubiksCubeSolver.Model
{
    public class Face
    {
        public Colors[,] Tiles { get; set; }
        public Face()
        {
            Tiles = new Colors[2,2];
        }
        public Face(Colors color)
        {
            Tiles = new Colors[2, 2] { 
                { color, color }, 
                { color, color }
            };
        }
    }

    public enum Colors
    {
        White,
        Yellow,
        Red,
        Orange,
        Blue,
        Green
    }
}