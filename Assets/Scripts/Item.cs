using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item
{
	public enum ITEM_TYPE
	{
		DRIVER,
		KEY,
		KEY2,
		CARD,
		HINT_CARD0,
		HINT_CARD1,
		HINT_CARD2,
		USB,
		HAMMER,

	}
	public ITEM_TYPE itemType;
	public Sprite sprite;

	public Item(ITEM_TYPE itemType,Sprite sprite)
	{
		this.itemType = itemType;
		this.sprite = sprite;
	}

}
