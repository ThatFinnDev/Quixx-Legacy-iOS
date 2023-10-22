using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealDice : MonoBehaviour
{

	public GameObject classicPrefab;
	public GameObject mixedPrefab;
	public GameObject mixedTwoPrefab;
	public GameObject longoPrefab;
	public GameObject instance = null;

	private void OnEnable()
	{
		if(instance!=null)
			Destroy(instance);
		switch (Main.sheetType)
		{
			case SheetType.Classic:
				instance = Instantiate(classicPrefab,transform);
				break;
			case SheetType.Mixed:
				instance = Instantiate(mixedPrefab,transform);
				break;
			case SheetType.MixedTwo:
				instance = Instantiate(mixedTwoPrefab,transform);
				break;
			case SheetType.Longo:
				instance = Instantiate(longoPrefab,transform);
				break;
		}
		instance.transform.SetSiblingIndex(1);
	}

	private void OnDisable()
	{
		if(instance!=null)
			Destroy(instance);
	}
}

public enum SheetType
{
	Classic,Mixed,MixedTwo,Longo
}