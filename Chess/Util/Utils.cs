using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Util
{
	public class Utils
	{
		public static int[] GetRealPosition(string position)
		{
			int line = Constants.LineReference[position[0].ToString()];
			int column = Constants.ColumnReference[position[1].ToString()];
			int[] realPosition = { line, column };
			return realPosition;
		}

		public static string NominatePosition(int line, int column)
		{
			string nominatedLine = Constants.LineReference.First(entries => entries.Value == line).Key;
			string nominatedColumn = Constants.ColumnReference.First(entries => entries.Value == column).Key;

			return nominatedLine + nominatedColumn;
		}
	}
}
