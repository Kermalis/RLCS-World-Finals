using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class TeamUI : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI _name;
	[SerializeField] private Image _logo;

	internal void Refresh(Team team, Sprite[] teamLogoSprites)
	{
		_name.text = team.Name;
		_logo.sprite = teamLogoSprites[(int)team.Logo];
	}
}