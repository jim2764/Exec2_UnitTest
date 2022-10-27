using Microsoft.VisualBasic;
using Ispan.DateTimeUtilities;

namespace TaiwainStockUtilitiesTests
{
	public class Tests
	{
		[TestCase(2022, 10, 29, 10, 0, false)]            // 星期六, 10:00  -> false
		public void Test_星期六_1000(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}

		[TestCase(2022, 10, 27, 8, 0, false)]             // 星期四,  8:00  -> false
		public void Test_星期四_0800(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}

		[TestCase(2022, 10, 29, 8, 0, false)]             // 星期六,  8:00  -> false
		public void Test_星期六_0800(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}

		[TestCase(2022, 10, 27, 13, 30, true)]           // 星期四, 13:30  -> true
		public void Test_星期四_1330(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}
	}
}