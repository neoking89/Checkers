namespace Checkers
{
	/// <summary>
	/// Piece Class. Instantiate with a color.
	/// </summary>
	public class Piece
    {
        public Color Color { get; set; }
        public (int, int)? Position { get; set; }
        public bool InPlay
        {
            get
            {
                return (Position != null);

            }
        }

        public Piece(Color color, (int, int) position)
        {
            Color = color;
            Position = position;
        }

        public override string ToString()
        {
            var color = Color == Color.White ? "W" : "B";
            return $"{color}, {Position}";
        }

        public (int, int)? this[int y, int x]
        {
            get
            {
                return Position;
            }
        }


    }
}