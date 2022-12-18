using Checkers;
using System.Linq;
using System.Diagnostics;
using System.Windows;



Board board = new();
board.CreatePieces();
foreach (var piece in board.CurrentPiecePositions)
{
    Console.WriteLine(piece.Value);
}




