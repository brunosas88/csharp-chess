using Chess.Entities.Enum;
using Chess.Entities.Struct;
using Chess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Entities
{
    public class Pawn : IChessPiece
	{
		public string Id { get; set; }
		public ChessPieceColor Color { get; set; }
		public string Position { get; set; }
		public string Sprite { get; set; }
		public bool IsCaptured { get; set; }
		public bool IsPromoted { get; set; }
		public bool IsFirstMove { get; private set; }

		public Pawn(ChessPieceColor color, string position, string sprite)
		{
			Color = color;
			Position = position;
			Sprite = sprite;
			IsCaptured = false;
			IsPromoted = false;
			IsFirstMove = true;
			Color = color;
		}

		public List<string> Move(string currentPosition, List<ChessPieceInfo> infoGamePieces)
		{
			int[] realPosition = Util.GetRealPosition(currentPosition);
			int currentLinePosition = realPosition[0], currentColumnPosition = realPosition[1], newLinePosition, newColumnPosition;
			string newPosition, leftDiagonalPosition, rightDiagonalPosition;
			bool isMovimentPossible;
			List<string> possibleMoves = new List<string>();

			newLinePosition = Color == ChessPieceColor.WHITE ?
			currentLinePosition - 1 :
			currentLinePosition + 1;
			newPosition = Util.NominatePosition(newLinePosition, currentColumnPosition);
			isMovimentPossible = CheckMove(infoGamePieces, newPosition, possibleMoves);

			if (IsFirstMove && isMovimentPossible)
			{
				newLinePosition = Color == ChessPieceColor.WHITE ?
					currentLinePosition - 2 :
					currentLinePosition + 2;
				newPosition = Util.NominatePosition(newLinePosition, currentColumnPosition);
				CheckMove(infoGamePieces, newPosition, possibleMoves);
				IsFirstMove = false;
			}

			CheckAtack(infoGamePieces, currentLinePosition, currentColumnPosition, possibleMoves);

			return possibleMoves;
		}

		private void CheckAtack(List<ChessPieceInfo> infoGamePieces, int currentLinePosition, int currentColumnPosition, List<string> possibleMoves)
		{
			string leftDiagonalPosition;
			string rightDiagonalPosition;

			if(currentColumnPosition > 0 && currentColumnPosition < 8)
			{
				
				leftDiagonalPosition = Color == ChessPieceColor.WHITE ? 
					Util.NominatePosition(currentLinePosition - 1, currentColumnPosition - 1) :
					Util.NominatePosition(currentLinePosition + 1, currentColumnPosition - 1);

				if ((infoGamePieces.Exists(piece => piece.Position == leftDiagonalPosition && piece.Color != this.Color)))
					possibleMoves.Add(leftDiagonalPosition);
			}
			
			if (currentColumnPosition >= 0 && currentColumnPosition < 7)
			{
				rightDiagonalPosition = Color == ChessPieceColor.WHITE ?
					Util.NominatePosition(currentLinePosition - 1, currentColumnPosition + 1) :
					Util.NominatePosition(currentLinePosition + 1, currentColumnPosition + 1);
				if ((infoGamePieces.Exists(piece => piece.Position == rightDiagonalPosition && piece.Color != this.Color)))
					possibleMoves.Add(rightDiagonalPosition);
			}
		}

		private bool CheckMove(List<ChessPieceInfo> infoGamePieces, string newPosition, List<string> possibleMoves)
		{

			if (!infoGamePieces.Exists(piece => piece.Position == newPosition))
			{
				possibleMoves.Add(newPosition);
				return true;
			}
			else
				return false;			
		}


	}
}
