using UnityEngine;

[CreateAssetMenu]
public sealed class RLCSSeason : ScriptableObject
{
	public byte Counter;
	[TextArea(5, 10)]
	public string Info;
	public Date Date;
	public Team[] Teams;
	public Player[] Players;
}