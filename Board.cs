using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers;

/// <summary>
/// This class is responsible for creating the board and the pieces.
/// </summary>
internal class Board

{
	public Color[,] Fields { get; set; } = new Color[10, 10];
    public Dictionary<(int, int), Piece> CurrentPiecePositions { get; set; } = new Dictionary<(int, int), Piece>();

    
    public Board()
    {
        CreateBoard();
    }


	/// <summary>
	/// Creates pieces on the board
	/// </summary>
	public void CreatePieces()
    
	{
		for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                if ((y < 3 || y > 6) && Fields[y,x] == Color.Black)
                {
                    {
                        CurrentPiecePositions.Add((y, x), new Piece(y < 3 ? Color.White : Color.Black));
                    }
                }
            }
        }
    }

    /// <summary>
    /// Create a board.
    /// </summary>
    public void CreateBoard()
    {
        for (int i = 0; i < Fields.GetLength(dimension: 0); i++)
        {
            for (int j = 0; j < Fields.GetLength(1); j++)
            {
                bool ColorChoice = (i + j) % 2 == 0;
                Fields[i, j] = ColorChoice ? Color.Black : Color.White;

            }
        }
    }


	public Piece? this[int y, int x]
	{
		get
		{
			if (CurrentPiecePositions.ContainsKey((y, x)))
			{
				return CurrentPiecePositions[(y, x)];
			}
			else
			{
				return null;
			}
		}
	}
}
