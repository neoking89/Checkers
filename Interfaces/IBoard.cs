namespace Checkers.Interfaces
{
    public interface IBoard
    {
        Piece? this[int y, int x] { get; }

        Dictionary<(int, int), Piece> CurrentPiecePositions { get; set; }
        Color[,] Fields { get; set; }

        void CreateBoard();
        void CreatePieces();
        void PrintBoard();
    }
}