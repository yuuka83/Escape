using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
	[SerializeField] GameObject sidePanel;
	[SerializeField] Image mainPanel;
	Item item;
	// アイテムを受け取ったらアイテムをもつ，画像スロットに表示する
	public void SetIcon(Item item)
	{
		this.item = item;
		if (item == null)
		{
			mainPanel.sprite = null;
		}
		else
		{
			
			mainPanel.sprite = item.sprite;
		}
	}

	public void ShowSelectedIcon()
	{
		if (item != null)
		{
			sidePanel.SetActive(true);
		}
	}
	public void HideSelectedIcon()
	{
		sidePanel.SetActive(false);
	}



	public bool IsEmpty()
	{
		if(item == null)
		{
			return true;
		}
		return false;
	}

	public Item GetItem()
	{
		return item;
	}
}
