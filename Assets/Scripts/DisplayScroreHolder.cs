using UnityEngine;
using UnityEngine.UI;

public class DisplayScroreHolder : MonoBehaviour
{
	[SerializeField] private Text _textScore;
	[SerializeField] private Text _textCountDiamond;

	private void Start()
	{
		ScoreHanlder.Instance.OnScroreUpdateAction += UpdateDisplayScore;
		ScoreHanlder.Instance.OnDiamondUpdateAction += UpdateDisplayDiamond;
	}

	private void UpdateDisplayScore(int score)
	{
		_textScore.text = score.ToString();
	}

	private void UpdateDisplayDiamond(int count)
	{
		_textCountDiamond.text = count.ToString();
	}
}
