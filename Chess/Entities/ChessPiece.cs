using Chess.Entities.Enum;
using Chess.Entities.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Entities
{
	public abstract class ChessPiece : IChessPiece
	{	
		public ChessPieceColor Color { get; set; }
		public string Position { get; set; }
		public string Sprite { get; set; }
		public bool IsCaptured { get; set; }

		public abstract List<string> Move(string currentPosition, List<ChessPieceInfo> infoGamePieces);
	}
}
