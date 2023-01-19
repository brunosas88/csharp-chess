using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Entities.Enum;
using Chess.Entities.Struct;

namespace Chess.Entities
{
    public interface IChessPiece
	{
		string Id { get; set; }
		ChessPieceColor Color { get; set; }
		string Position { get; set; }
		string Sprite { get; set; }
		bool IsCaptured { get; set; }

		List<string> Move(string currentPosition, List<ChessPieceInfo> infoGamePieces);

	}
}
