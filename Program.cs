using Checkers;
using System.Linq;
using System.Diagnostics;
using System.Windows;


//var myWriter = new TextWriterTraceListener(System.Console.Out);
//Debug.Listeners.Add(myWriter);
//Debug.

Board board = new();
board.CreatePieces();



foreach (var item in board.CurrentPiecePositions)
{
	Console.WriteLine(item.Key.Item1 + " " + item.Key.Item2 + " " + item.Value.Color);
	
}
