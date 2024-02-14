using System;

[Serializable]
public sealed class Player
{
	public string Name;
	public Date BirthDate;
	public Country Country;
	public Placement[] Placements;
}