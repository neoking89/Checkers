namespace Checkers.Interfaces
{
    public interface IPiece
    {
        (int, int)? this[int y, int x] { get; }

        Color Color { get; set; }
        bool InPlay { get; }
        (int, int)? Position { get; set; }

        string ToString();
    }
}