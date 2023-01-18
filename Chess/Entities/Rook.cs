using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Entities.Enum;
using Chess.Utils;

namespace Chess.Entities
{
    public class Rook : IChessPiece
	{
		public string Id { get; set; }
		public ChessPieceColor Color { get; set; }
		public string Position { get; set; }
		public string Sprite { get; set; }
		public bool IsCaptured { get; set; }

		public Rook(ChessPieceColor color, string position, string sprite)
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
			List<string> possibleMoves = new List<string>();

			newLinePosition = currentLinePosition;
			for (int up = currentLinePosition; up > 0; up--)
			{
				newLinePosition -= 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));				
			}

			newLinePosition = currentLinePosition;
			for (int down = currentLinePosition; down < 7; down++)
			{
				newLinePosition += 1;
				possibleMoves.Add(Util.NominatePosition(newLinePosition, currentColumnPosition));
			}

			newColumnPosition = currentColumnPosition;
			for (int right = currentColumnPosition; right < 7; right++)
			{
				newColumnPosition += 1;
				possibleMoves.Add(Util.NominatePosition(currentLinePosition, newColumnPosition));
			}

			newColumnPosition = currentColumnPosition;
			for (int left = currentColumnPosition; left > 0; left--)
			{
				newColumnPosition -= 1;
				possibleMoves.Add(Util.NominatePosition(currentLinePosition, newColumnPosition));
			}

			return possibleMoves;
		}
	}
}
