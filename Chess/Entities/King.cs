using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Entities.Enum;
using Chess.Utils;

namespace Chess.Entities
{
    public class King : IChessPiece
	{
		public string Id { get; set; }
		public ChessPieceColor Color { get; set; }
		public string Position { get; set; }
		public string Sprite { get; set; }
		public bool IsCaptured { get; set; }


		public King(ChessPieceColor color, string position, string sprite)
		{
			Color = color;
			Position = position;
			Sprite = sprite;
			IsCaptured = false;
		}

		public List<string> Move(string currentPosition)
		{
			int[] realPosition = Util.GetRealPosition(currentPosition);
			int currentLinePosition = realPosition[0], currentColumnPosition = realPosition[1], newLinePosition, newColumnPosition;
			int up, left, right, down;
			List<string> possibleMoves = new List<string>();

			newLinePosition = currentLinePosition;
			newColumnPosition = currentColumnPosition;
			up = currentLinePosition;
			left = currentColumnPosition;
			if( up > 0 && left > 0)
			{
				newLinePosition -= 1;
				newColumnPosition -= 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			newColumnPosition = currentColumnPosition;
			up = currentLinePosition;
			right = currentColumnPosition;
			if (up > 0 && right < 7)
			{
				newLinePosition -= 1;
				newColumnPosition += 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			newColumnPosition = currentColumnPosition;
			down = currentLinePosition;
			left = currentColumnPosition;
			if (down < 7 && left > 0)
			{
				newLinePosition += 1;
				newColumnPosition -= 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			newColumnPosition = currentColumnPosition;
			down = currentLinePosition;
			right = currentColumnPosition;
			if (down < 7 && right < 7)
			{
				newLinePosition += 1;
				newColumnPosition += 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			up = currentLinePosition;
			if (up > 0)
			{
				newLinePosition -= 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));
			}

			newLinePosition = currentLinePosition;
			down = currentLinePosition;
			if (down < 7)
			{
				newLinePosition += 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));
			}

			newColumnPosition = currentColumnPosition;
			right = currentColumnPosition;
			if (right < 7)
			{
				newColumnPosition += 1;
				possibleMoves.Add(Util.NominatePosition(currentLinePosition, newColumnPosition));
			}

			newColumnPosition = currentColumnPosition;
			left = currentColumnPosition;
			if (left > 0)
			{
				newColumnPosition -= 1;
				possibleMoves.Add(Util.NominatePosition(currentLinePosition, newColumnPosition));
			}

			return possibleMoves;
		}
	}
}
