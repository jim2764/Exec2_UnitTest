using Microsoft.VisualBasic;
using Ispan.DateTimeUtilities;

namespace TaiwainStockUtilitiesTests
{
	public class Tests
	{
		[TestCase(2022, 10, 29, 10, 0, false)]            // �P����, 10:00  -> false
		public void Test_�P����_1000(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}

		[TestCase(2022, 10, 27, 8, 0, false)]             // �P���|,  8:00  -> false
		public void Test_�P���|_0800(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}

		[TestCase(2022, 10, 29, 8, 0, false)]             // �P����,  8:00  -> false
		public void Test_�P����_0800(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}

		[TestCase(2022, 10, 27, 13, 30, true)]           // �P���|, 13:30  -> true
		public void Test_�P���|_1330(int year, int month, int day, int hour,
									int minute, bool expected)
		{
			DateTime targetDateTime = new DateTime(year, month, day, hour, minute, 0);

			TaiwainStockUtility utility = new TaiwainStockUtility();

			bool isAnswer = utility.IsTradingTiming(targetDateTime);

			Assert.AreEqual(expected, isAnswer);
		}
	}
}