using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossButton : MonoBehaviour
{
	public ColorType type;
	public bool active = false;
	public GameObject crossPartOne;
	public GameObject crossPartTwo;
	public Game game;
	public Button deactiveButton;
	public void Press()
	{
		active = !active;
		crossPartOne.SetActive(active);
		crossPartTwo.SetActive(active);
		if (deactiveButton != null)
			deactiveButton.interactable = !active;
		switch (type)
		{
			case ColorType.Red:
				game.redPressedCount+= (active ? 1 : -1);
				break;
			case ColorType.Yellow:
				game.yellowPressedCount+= (active ? 1 : -1);
				break;
			case ColorType.Green:
				game.greenPressedCount+= (active ? 1 : -1);
				break;
			case ColorType.Blue:
				game.bluePressedCount+= (active ? 1 : -1);
				break;
			case ColorType.Minus:
				game.minusPressedCount+= (active ? 1 : -1);
				break;
		}
		
	}
}

public enum ColorType
{
	Red,Yellow,Green,Blue,Minus
}