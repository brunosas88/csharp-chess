using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Entities.Enum;
using Chess.Utils;

namespace Chess.Entities
{
    internal class Queen : IChessPiece
	{
		public string Id { get; set; }
		public ChessPieceColor Color { get; set; }
		public string Position { get; set; }
		public string Sprite { get; set; }
		public bool IsCaptured { get; set; }

		public Queen(ChessPieceColor color, string position, string sprite)
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
			for (up = currentLinePosition, left = currentColumnPosition; up > 0 && left > 0; up--, left--)
			{
				newLinePosition -= 1;
				newColumnPosition -= 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			newColumnPosition = currentColumnPosition;
			for (up = currentLinePosition, right = currentColumnPosition; up > 0 && right < 7; up--, right++)
			{
				newLinePosition -= 1;
				newColumnPosition += 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			newColumnPosition = currentColumnPosition;
			for (down = currentLinePosition, left = currentColumnPosition; down < 7 && left > 0; down++, left--)
			{
				newLinePosition += 1;
				newColumnPosition -= 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			newColumnPosition = currentColumnPosition;
			for (down = currentLinePosition, right = currentColumnPosition; down < 7 && right < 7; down++, right++)
			{
				newLinePosition += 1;
				newColumnPosition += 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition;
			for (up = currentLinePosition; up > 0; up--)
			{
				newLinePosition -= 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));
			}

			newLinePosition = currentLinePosition;
			for (down = currentLinePosition; down < 7; down++)
			{
				newLinePosition += 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));
			}

			newColumnPosition = currentColumnPosition;
			for (right = currentColumnPosition; right < 7; right++)
			{
				newColumnPosition += 1;
				possibleMoves.Add(Util.NominatePosition(currentLinePosition, newColumnPosition));
			}

			newColumnPosition = currentColumnPosition;
			for (left = currentColumnPosition; left > 0; left--)
			{
				newColumnPosition -= 1;
				possibleMoves.Add(Util.NominatePosition(currentLinePosition, newColumnPosition));
			}

			return possibleMoves;
		}
	}
}
