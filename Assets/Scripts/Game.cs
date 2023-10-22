using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{

	public int redPressedCount = 0;
	public int yellowPressedCount = 0;
	public int greenPressedCount = 0;
	public int bluePressedCount = 0;
	public int minusPressedCount = 0;
	public Text redText;
	public Text yellowText;
	public Text greenText;
	public Text blueText;
	public Text minusText;
	public Text sumText;
	public Sprite dark_mode;
	public Image tex;
	public Text LuckNumberOne;
	public Text LuckNumberTwo;
	private void Awake()
	{
		if (PlayerPrefs.GetInt("useDarkMode", 0) == 1)
		{
			tex.sprite = dark_mode;
			redText.color = Color.white;
			yellowText.color = Color.white;
			greenText.color = Color.white;
			blueText.color = Color.white;
			minusText.color = Color.white;
		}

		if (Main.sheetType == SheetType.Longo)
		{
			int random = Random.Range(0, 4);
			switch (random)
			{
				case 0:
					LuckNumberOne.text = "5";
					LuckNumberTwo.text = "10";
					break;
				case 1:
					LuckNumberOne.text = "7";
					LuckNumberTwo.text = "12";
					break;
				case 2:
					LuckNumberOne.text = "8";
					LuckNumberTwo.text = "13";
					break;
				case 3:
					LuckNumberOne.text = "6";
					LuckNumberTwo.text = "11";
					break;
			}
		}
	}

	void Update ()
	{
		redText.text = countToValue(redPressedCount).ToString();
		yellowText.text = countToValue(yellowPressedCount).ToString();
		greenText.text = countToValue(greenPressedCount).ToString();
		blueText.text = countToValue(bluePressedCount).ToString();
		minusText.text = (minusPressedCount*5).ToString();
		sumText.text = (countToValue(redPressedCount) + countToValue(yellowPressedCount) + countToValue(greenPressedCount) + countToValue(bluePressedCount) - minusPressedCount*5).ToString();
	}

	public int countToValue(int value)
	{
		switch (value)
		{
			case 1: return 1;
			case 2: return 3;
			case 3: return 6;
			case 4: return 10;
			case 5: return 15;
			case 6: return 21;
			case 7: return 28;
			case 8: return 36;
			case 9: return 45;
			case 10: return 55;
			case 11: return 66;
			case 12: return 78;
			case 13: return 91;
			case 14: return 105;
			case 15: return 120;
		}

		return 0;
	}
}
