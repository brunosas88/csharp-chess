using Chess.Entities.Enum;
using Chess.Entities.Struct;
using Chess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.View
{
	public class Display
	{
		public static void PrintBoard(ChessPieceInfo[,] board)
		{
			Console.Clear();
			char[] colReference = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
			char[] rowReference = { '8', '7', '6', '5', '4', '3', '2', '1' };
			List<ConsoleColor> colors = new List<ConsoleColor> { ConsoleColor.Gray, ConsoleColor.DarkGray };
			bool isDarkerColor = true;
			Console.WriteLine();

			Console.Write("   ");
			foreach (char reference in colReference)
				Console.Write(" " + reference + " ");

			Console.WriteLine();

			for (int row = 0; row < board.GetLength(0); row++)
			{
				Console.Write(" " + rowReference[row] + " ");

				for (int col = 0; col < board.GetLength(1); col++)
				{
					Console.BackgroundColor = isDarkerColor? colors[0] : colors[1];

					Console.Write(" ");
					Console.ForegroundColor = board[row, col].Color == ChessPieceColor.WHITE ? ConsoleColor.White : ConsoleColor.Black;
					Console.Write(board[row, col].Sprite);
					Console.ForegroundColor = Constants.MAIN_FOREGROUND_COLOR;
					Console.Write(" ");			

					isDarkerColor = !isDarkerColor;
				}
				Console.BackgroundColor = ConsoleColor.Black;
				colors.Reverse();
				Console.WriteLine();
			}
			Console.BackgroundColor = Constants.MAIN_BACKGROUND_COLOR; 
			Console.ForegroundColor = Constants.MAIN_FOREGROUND_COLOR;
		}
	}
}
