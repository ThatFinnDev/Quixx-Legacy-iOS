using UnityEngine;
using UnityEngine.UI;

public class DiceOnly : MonoBehaviour {
	
	public Text whiteDiceOne;
	public Text whiteDiceTwo;
	public Text redDice;
	public Text yellowDice;
	public Text greenDice;
	public Text blueDice;
	
	public void Dice()
	{
		int max = (Main.sheetType == SheetType.Longo)?9:7;

		setNumberonDice(whiteDiceOne.transform, Random.Range(1, max));
		setNumberonDice(whiteDiceTwo.transform, Random.Range(1, max));
		setNumberonDice(redDice.transform, Random.Range(1, max));
		setNumberonDice(yellowDice.transform, Random.Range(1, max));
		setNumberonDice(greenDice.transform, Random.Range(1, max));
		setNumberonDice(blueDice.transform, Random.Range(1, max));
	}

	private bool useDots = false;
	private void OnEnable()
	{
		useDots = PlayerPrefs.GetInt("useDots", 0)==1;
		setNumberonDice(whiteDiceOne.transform,0);
		setNumberonDice(whiteDiceTwo.transform,0);
		setNumberonDice(redDice.transform,0);
		setNumberonDice(yellowDice.transform,0);
		setNumberonDice(greenDice.transform,0);
		setNumberonDice(blueDice.transform,0);
	}

	void setNumberonDice(Transform diceText, int number)
	{
		Transform dice = diceText.parent;
		foreach (Transform child in dice)
		{ child.gameObject.SetActive(false); }

		if (!useDots)
		{
			diceText.GetComponent<Text>().text = number.ToString();
			diceText.gameObject.SetActive(true);
		}
		else
		{
			switch (number)
			{
				case 0:
				case 1:
					dice.GetChild(4).gameObject.SetActive(true);
					break;
				case 2:
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					break;
				case 3:
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(4).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					break;
				case 4:
					dice.GetChild(0).gameObject.SetActive(true);
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					dice.GetChild(8).gameObject.SetActive(true);
					break;
				case 5:
					dice.GetChild(0).gameObject.SetActive(true);
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(4).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					dice.GetChild(8).gameObject.SetActive(true);
					break;
				case 6:
					dice.GetChild(0).gameObject.SetActive(true);
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(3).gameObject.SetActive(true);
					dice.GetChild(5).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					dice.GetChild(8).gameObject.SetActive(true);
					break;
				case 7:
					dice.GetChild(0).gameObject.SetActive(true);
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(3).gameObject.SetActive(true);
					dice.GetChild(4).gameObject.SetActive(true);
					dice.GetChild(5).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					dice.GetChild(8).gameObject.SetActive(true);
					break;
				case 8:
					dice.GetChild(0).gameObject.SetActive(true);
					dice.GetChild(1).gameObject.SetActive(true);
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(3).gameObject.SetActive(true);
					dice.GetChild(5).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					dice.GetChild(7).gameObject.SetActive(true);
					dice.GetChild(8).gameObject.SetActive(true);
					break;
				case 9:
					dice.GetChild(0).gameObject.SetActive(true);
					dice.GetChild(1).gameObject.SetActive(true);
					dice.GetChild(2).gameObject.SetActive(true);
					dice.GetChild(3).gameObject.SetActive(true);
					dice.GetChild(4).gameObject.SetActive(true);
					dice.GetChild(5).gameObject.SetActive(true);
					dice.GetChild(6).gameObject.SetActive(true);
					dice.GetChild(7).gameObject.SetActive(true);
					dice.GetChild(8).gameObject.SetActive(true);
					break;
			}

		}
	}
}
