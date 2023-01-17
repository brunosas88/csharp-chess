using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Entities.Enum;

namespace Chess.Entities
{
    internal class Queen : IChessPiece
	{
		public string Id { get; set; }
		public ChessPieceColor Color { get; set; }
		public string Position { get; set; }
		public string Sprite { get; set; }
		public bool IsCaptured { get; set; }

		public List<string> Move(string currentPosition)
		{
			throw new NotImplementedException();
		}
	}
}
