using Chess.Entities.Enum;
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

		public List<string> Move(string currentPosition)
		{
			int[] realPosition = Util.GetRealPosition(currentPosition);
			int currentLinePosition = realPosition[0], currentColumnPosition = realPosition[1], newLinePosition;
			List<string> possibleMoves = new List<string>();			

			if (IsFirstMove)
			{
				newLinePosition = Color == ChessPieceColor.WHITE ?
					currentLinePosition - 2 :
					currentLinePosition + 2;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));
				IsFirstMove = false;
			}

			newLinePosition = Color == ChessPieceColor.WHITE ?
					currentLinePosition - 1 :
					currentLinePosition + 1;
			possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));

			return possibleMoves;
		}


	}
}
