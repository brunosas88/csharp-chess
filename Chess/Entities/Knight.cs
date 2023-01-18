using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Entities.Enum;
using Chess.Utils;

namespace Chess.Entities
{
    public class Knight : IChessPiece
	{
		public string Id { get; set; }
		public ChessPieceColor Color { get; set; }
		public string Position { get; set; }
		public string Sprite { get; set; }
		public bool IsCaptured { get; set; }

		public Knight(ChessPieceColor color, string position, string sprite)
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



			// posições acima 
			newLinePosition = currentLinePosition - 2;
			if (newLinePosition >= 0)
			{
				newColumnPosition = currentColumnPosition + 1;
				if (newColumnPosition <= 7)				
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));				

				newColumnPosition = currentColumnPosition - 1;
				if (newColumnPosition >= 0)
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition - 1;
			if (newLinePosition >= 0)
			{
				newColumnPosition = currentColumnPosition + 2;
				if (newColumnPosition <= 7)
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));

				newColumnPosition = currentColumnPosition - 2;
				if (newColumnPosition >= 0)
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			// posições abaixo 
			newLinePosition = currentLinePosition + 1;
			if (newLinePosition <= 7)
			{
				newColumnPosition = currentColumnPosition + 2;
				if (newColumnPosition <= 7)
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));

				newColumnPosition = currentColumnPosition - 2;
				if (newColumnPosition >= 0)
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}

			newLinePosition = currentLinePosition + 2;
			if (newLinePosition <= 7)
			{
				newColumnPosition = currentColumnPosition + 1;
				if (newColumnPosition <= 7)
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));

				newColumnPosition = currentColumnPosition - 1;
				if (newColumnPosition >= 0)
					possibleMoves.Add(Util.NominatePosition(newLinePosition, newColumnPosition));
			}


			return possibleMoves;
		}
	}
}
