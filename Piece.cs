namespace Checkers
{
	/// <summary>
	/// Piece Class. Instantiate with a color.
	/// </summary>
	public class Piece
    {
        public Color Color { get; set; }
        public Piece(Color color)
        {
            Color = color;
        }

    }
}