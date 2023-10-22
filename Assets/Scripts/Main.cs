using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
	public GameObject realDice;
	public GameObject virtualDice;
	public GameObject onlyDice;
	public Text modeText;
	public static SheetType sheetType=SheetType.Classic;

	public Toggle useDarkMode;
	public Toggle useDots;

	private void Awake()
	{
		useDarkMode.isOn = PlayerPrefs.GetInt("useDarkMode", 0)==1;
		useDots.isOn = PlayerPrefs.GetInt("useDots", 0)==1;
	}

	public void switchGameMode()
	{
		switch (sheetType)
		{
			case SheetType.Classic:
				sheetType = SheetType.Mixed;
				modeText.text = "Mixed";
				break;
			case SheetType.Mixed:
				sheetType = SheetType.MixedTwo;
				modeText.text = "Mixed 2";
				break;
			case SheetType.MixedTwo:
				sheetType = SheetType.Longo;
				modeText.text = "Longo";
				break;
			case SheetType.Longo:
				sheetType = SheetType.Classic;
				modeText.text = "Classic";
				break;
		}
	}

	public void setDarkMode(bool on)
	{
		PlayerPrefs.SetInt("useDarkMode", on ? 1 : 0);
		PlayerPrefs.Save();
	}
	public void setDots(bool on)
	{
		PlayerPrefs.SetInt("useDots", on ? 1 : 0);
		PlayerPrefs.Save();
	}
	public void DiceOnly()
	{
		onlyDice.SetActive(true);
	}

	public void RealDice()
	{
		realDice.SetActive(true);
	}

	public void VirtualDice()
	{
		
		virtualDice.SetActive(true);
	}
}
