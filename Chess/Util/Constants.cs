using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Util
{
	public class Constants
	{
		public static readonly Dictionary<string, int> LineReference = new Dictionary<string, int>
		{
			{"8", 0}, {"7", 1}, {"6", 2}, {"5", 3}, {"4", 4}, {"3", 5}, {"2", 6}, {"1", 7}
		};
		public static readonly Dictionary<string, int> ColumnReference = new Dictionary<string, int>
		{
			{"a", 0}, {"b", 1}, {"c", 2}, {"d", 3}, {"e", 4}, {"f", 5}, {"g", 6}, {"h", 7}
		};
	}
}
