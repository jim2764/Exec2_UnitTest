using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.DateTimeUtilities
{
	public class TaiwainStockUtility
	{
		public bool IsTradingTiming(DateTime dt)
		{
			bool isRight = false;

			DayOfWeek targetWeek = dt.DayOfWeek;

			DateTime nineTime = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0);

			DateTime oneTime = new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0);

			if ((targetWeek >= DayOfWeek.Monday && targetWeek <= DayOfWeek.Friday)
				&& dt >= nineTime && dt <= oneTime)
				isRight = true;

			return isRight;
		}
	}
}
