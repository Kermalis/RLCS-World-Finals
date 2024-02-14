using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class PlayerUI : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI _name;
	[SerializeField] private Image _flag;
	[SerializeField] private TextMeshProUGUI _text;
	[SerializeField] private GameObject _placementParent;
	[SerializeField] private Image[] _placements;

	internal void Refresh(Date eventDate, Player player, Sprite[] flagSprites, Sprite[] placementSprites)
	{
		_name.text = player.Name;

		_flag.sprite = flagSprites[(int)player.Country];

		_text.text = Date.GetPlayerAge(eventDate, player.BirthDate).ToString();

		Placement[] place = player.Placements;
		if (place is not null && place.Length > 0)
		{
			for (int i = 0; i < _placements.Length; i++)
			{
				Image img = _placements[i];
				if (i >= place.Length)
				{
					img.enabled = false;
				}
				else
				{
					Placement p = place[i];
					if (p == Placement.None)
					{
						img.enabled = false;
					}
					else
					{
						img.sprite = placementSprites[(int)p - 1];
						img.enabled = true;
					}
				}
			}
			_placementParent.SetActive(true);
		}
		else
		{
			_placementParent.SetActive(false);
		}
	}
}