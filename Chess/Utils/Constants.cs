using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Utils
{
	public static class Constants
	{
		public static readonly Dictionary<string, int> LINE_REFERENCE = new Dictionary<string, int>
		{
			{"8", 0}, {"7", 1}, {"6", 2}, {"5", 3}, {"4", 4}, {"3", 5}, {"2", 6}, {"1", 7}
		};
		public static readonly Dictionary<string, int> COLUMN_REFERENCE = new Dictionary<string, int>
		{
			{"a", 0}, {"b", 1}, {"c", 2}, {"d", 3}, {"e", 4}, {"f", 5}, {"g", 6}, {"h", 7}
		};
		public const string BISHOP_SPRITE = "B";		
		public const string KING_SPRITE = "K";
		public const string KNIGHT_SPRITE = "T";
		public const string PAWN_SPRITE = "P";
		public const string QUEEN_SPRITE = "Q";
		public const string ROOK_SPRITE = "R";
		public const ConsoleColor MAIN_FOREGROUND_COLOR = ConsoleColor.Gray;
		public const ConsoleColor MAIN_BACKGROUND_COLOR = ConsoleColor.Black;

	}
}
