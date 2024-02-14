using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public sealed class MainScript : MonoBehaviour
{
	[SerializeField] private bool _update;
	[SerializeField] private RLCSSeason _season;
	[SerializeField] private TextMeshProUGUI _info;
	[SerializeField] private TeamUI[] _teams;
	[SerializeField] private PlayerUI[] _players;

	[SerializeField] private Sprite[] _flagSprites;
	[SerializeField] private Sprite[] _placementSprites;
	[SerializeField] private Sprite[] _teamLogoSprites;
	[SerializeField] private TextMeshProUGUI[] _placementTexts;

	private void Update()
	{
		if (!_update)
		{
			return;
		}

		_update = false;

		_info.text = _season.Info;

		_teams[0].Refresh(_season.Teams[0], _teamLogoSprites);
		_teams[1].Refresh(_season.Teams[1], _teamLogoSprites);

		for (int i = 5; i >= 0; i--)
		{
			_players[i].Refresh(_season.Date, _season.Players[i], _flagSprites, _placementSprites);
		}

		for (int i = 0; i < _placementTexts.Length; i++)
		{
			_placementTexts[i].enabled = _season.Counter > i;
		}
	}
}