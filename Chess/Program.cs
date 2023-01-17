using Chess.Entities;
using Chess.Entities.Enum;
using Chess.Entities.Struct;
using Chess.Utils;
using Chess.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	public class Program
	{
		static void Main(string[] args)
		{
			ChessBoard board = new ChessBoard();


			ChessPieceInfo newPiece = new();
			newPiece.Position = "c2";
			newPiece.Color = ChessPieceColor.WHITE;
			newPiece.Sprite = Constants.PAWN_SPRITE;
			List < ChessPieceInfo > chessPieces = new List < ChessPieceInfo >();
			chessPieces.Add(newPiece);
			board.UpdateBoard(chessPieces);
			Display.PrintBoard(board.Board);
			Console.ReadLine();
		}
	}
}
