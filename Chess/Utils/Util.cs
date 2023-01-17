using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Utils
{
	public class Util
	{
		public static int[] GetRealPosition(string position)
		{
			int row = Constants.LINE_REFERENCE[position[1].ToString()];
			int column = Constants.COLUMN_REFERENCE[position[0].ToString()];
			int[] realPosition = { row, column };
			return realPosition;
		}

		public static string NominatePosition(int line, int column)
		{
			string nominatedLine = Constants.LINE_REFERENCE.First(entries => entries.Value == line).Key;
			string nominatedColumn = Constants.COLUMN_REFERENCE.First(entries => entries.Value == column).Key;

			return nominatedLine + nominatedColumn;
		}
	}
}
