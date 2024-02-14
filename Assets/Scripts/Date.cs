using System;

[Serializable]
public struct Date
{
	public Month Month;
	public byte Day;
	public ushort Year;

	private readonly DateTime ToDateTime()
	{
		return new DateTime(Year, (int)Month + 1, Day);
	}

	public static int GetPlayerAge(Date date, Date playerBirth)
	{
		var dDate = date.ToDateTime();
		var pDate = playerBirth.ToDateTime();

		int age = dDate.Year - pDate.Year;

		// Leap year check
		// Feb 29 2000 to Feb 28 2010: age = 10, then age-- to 9
		// Feb 29 2000 to Mar 01 2010: age = 10
		if (pDate > dDate.AddYears(-age))
		{
			age--;
		}

		return age;
	}
}