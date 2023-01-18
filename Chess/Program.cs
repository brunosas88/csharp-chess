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
		public static void Main(string[] args)
		{
			ChessBoard board = new ChessBoard();
			List<IChessPiece> inGamePieces = InitializeChessPieces();
			List<ChessPieceInfo> infoGamePieces = InitializeInfoChessPieces(inGamePieces);
			board.UpdateBoard(infoGamePieces);
			Display.PrintBoard(board.Board);

			string position = Console.ReadLine();

			var piece = inGamePieces.Find(piece => piece.Position == position);
			List<string> possibleMoves = piece.Move(position);
			foreach (var item in possibleMoves)
			{
				Console.WriteLine(item);
			}

			position = Console.ReadLine();

			piece = inGamePieces.Find(piece => piece.Position == position);
			possibleMoves = piece.Move(position);
			foreach (var item in possibleMoves)
			{
				Console.WriteLine(item);
			}

		}

		public static List<ChessPieceInfo> InitializeInfoChessPieces(List<IChessPiece> inGamePieces)
		{
			List<ChessPieceInfo> piecesInfoList = new();
			ChessPieceInfo newPiece = new();

			foreach (IChessPiece piece in inGamePieces)
			{
				newPiece.Position = piece.Position;
				newPiece.Color = piece.Color;
				newPiece.Sprite = piece.Sprite;
				piecesInfoList.Add(newPiece);
			}

			return piecesInfoList;
		}

		public static List<IChessPiece> InitializeChessPieces()
		{			
			// Creating king pieces
			King kingW = new King(ChessPieceColor.WHITE, "e1", Constants.KING_SPRITE);
			King kingB = new King(ChessPieceColor.BLACK, "e8", Constants.KING_SPRITE);
			// Creating queen pieces
			Queen queenW = new Queen(ChessPieceColor.WHITE, "d1", Constants.QUEEN_SPRITE);
			Queen queenB = new Queen(ChessPieceColor.BLACK, "d8", Constants.QUEEN_SPRITE);
			// Creating bishops pieces
			Bishop bishopWC = new Bishop(ChessPieceColor.WHITE, "c1", Constants.BISHOP_SPRITE);
			Bishop bishopWF = new Bishop(ChessPieceColor.WHITE, "f1", Constants.BISHOP_SPRITE);
			Bishop bishopBC = new Bishop(ChessPieceColor.BLACK, "c8", Constants.BISHOP_SPRITE);
			Bishop bishopBF = new Bishop(ChessPieceColor.BLACK, "f8", Constants.BISHOP_SPRITE);
			// Creating knight pieces
			Knight knightWB = new Knight(ChessPieceColor.WHITE, "b1", Constants.KNIGHT_SPRITE);
			Knight knightWG = new Knight(ChessPieceColor.WHITE, "g1", Constants.KNIGHT_SPRITE);
			Knight knightBB = new Knight(ChessPieceColor.BLACK, "b8", Constants.KNIGHT_SPRITE);
			Knight knightBG = new Knight(ChessPieceColor.BLACK, "g8", Constants.KNIGHT_SPRITE);
			// Creating rook pieces
			Rook rookWA = new Rook(ChessPieceColor.WHITE, "a1", Constants.ROOK_SPRITE);
			Rook rookWH = new Rook(ChessPieceColor.WHITE, "h1", Constants.ROOK_SPRITE);
			Rook rookBA = new Rook(ChessPieceColor.BLACK, "a8", Constants.ROOK_SPRITE);
			Rook rookBH = new Rook(ChessPieceColor.BLACK, "h8", Constants.ROOK_SPRITE);
			// Creating pawn pieces
			Pawn pawnWA = new Pawn(ChessPieceColor.WHITE, "a2", Constants.PAWN_SPRITE);
			Pawn pawnWB = new Pawn(ChessPieceColor.WHITE, "b2", Constants.PAWN_SPRITE);
			Pawn pawnWC = new Pawn(ChessPieceColor.WHITE, "c2", Constants.PAWN_SPRITE);
			Pawn pawnWD = new Pawn(ChessPieceColor.WHITE, "d2", Constants.PAWN_SPRITE);
			Pawn pawnWE = new Pawn(ChessPieceColor.WHITE, "e2", Constants.PAWN_SPRITE);
			Pawn pawnWF = new Pawn(ChessPieceColor.WHITE, "f2", Constants.PAWN_SPRITE);
			Pawn pawnWG = new Pawn(ChessPieceColor.WHITE, "g2", Constants.PAWN_SPRITE);
			Pawn pawnWH = new Pawn(ChessPieceColor.WHITE, "h2", Constants.PAWN_SPRITE);
			Pawn pawnBA = new Pawn(ChessPieceColor.BLACK, "a7", Constants.PAWN_SPRITE);
			Pawn pawnBB = new Pawn(ChessPieceColor.BLACK, "b7", Constants.PAWN_SPRITE);
			Pawn pawnBC = new Pawn(ChessPieceColor.BLACK, "c7", Constants.PAWN_SPRITE);
			Pawn pawnBD = new Pawn(ChessPieceColor.BLACK, "d7", Constants.PAWN_SPRITE);
			Pawn pawnBE = new Pawn(ChessPieceColor.BLACK, "e7", Constants.PAWN_SPRITE);
			Pawn pawnBF = new Pawn(ChessPieceColor.BLACK, "f7", Constants.PAWN_SPRITE);
			Pawn pawnBG = new Pawn(ChessPieceColor.BLACK, "g7", Constants.PAWN_SPRITE);
			Pawn pawnBH = new Pawn(ChessPieceColor.BLACK, "h7", Constants.PAWN_SPRITE);

			return new List<IChessPiece>() 
			{	kingW, kingB, queenW, queenB, bishopWC, bishopWF, bishopBC, bishopBF, knightWB, knightWG,
				knightBB, knightBG, rookWA, rookWH, rookBA, rookBH, pawnWA, pawnWB, pawnWC, pawnWD, pawnWE,
				pawnWF, pawnWG, pawnWH, pawnBA, pawnBB, pawnBC, pawnBD, pawnBE, pawnBF, pawnBG, pawnBH
			};
		}
	}
}
