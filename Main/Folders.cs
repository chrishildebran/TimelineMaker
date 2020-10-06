// JH Kelly 2018
// Kelly Tools For Revit
// Last User: Chris Hildebran (CHildebran@jhkelly.com)
// Last Edit: 04/07/2018 - 6:52 PM
using System;
using System.Diagnostics;
using System.IO;

namespace TimelineMaker
{
	internal class Folders
	{
		#region Methods

		public static void Decade_Year_YearMonthDate()
		{
			var rootpath = @"C:\Temp\Decade_Year_Year-Month-Date_Weekday";

			var start  = new DateTime(1967, 07, 02);
			var finish = new DateTime(2018, 04, 06);

			var countNew      = 0;
			var countExisting = 0;

			var stopwatch = new Stopwatch();

			stopwatch.Start();

			for(var x = start; x <= finish; x = x.AddDays(1))
			{
				var decade = x.Year.ToString().Substring(0, 3) + "0s";

				var suffix = "_TBD";

				var yearPath = rootpath + "\\" + decade + "\\" + x.Year + "\\" + x.Year + "-" + x.Month.ToString("D2") + "-" + x.Day.ToString("D2") + "_" + x.DayOfWeek + "\\" + x.Year + "-" + x.Month.ToString("D2") + "-" + x.Day.ToString("D2") + suffix;

				if(!Directory.Exists(yearPath))
				{
					Directory.CreateDirectory(yearPath);
					countNew += 1;
				}
				else
				{
					countExisting += 1;
				}
			}
			stopwatch.Stop();
			var et = TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).TotalSeconds;
			Directory.CreateDirectory(rootpath + "\\Elapsed Time_" + et.ToString("##.00"));
			Directory.CreateDirectory(rootpath + "\\Folders Created_" + countNew);
			Directory.CreateDirectory(rootpath + "\\Folders Existing_" + countExisting);
		}

		#endregion
	}
}