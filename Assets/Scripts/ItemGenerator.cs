using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
	[SerializeField] ItemListEntity itemListEntity;
	public static ItemGenerator instance;

	private void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
	}

	public Item Spawn(Item.ITEM_TYPE itemType)
	{
		foreach(Item item in itemListEntity.itemList)
		{
			if(item.itemType == itemType)
			{
				return new Item(item.itemType, item.sprite);
			}
		}
		return null;
	}
}
