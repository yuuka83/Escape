using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    public static ItemBox instance;
	Item selectedItem;
	Slot selectedSlot;
	// Start is called before the first frame update
	private void Awake()
	{
		if(instance == null)
		{
            instance = this;
            slots = GetComponentsInChildren<Slot>();
        }
	}

	// アイテムをスロットに表示
	public void SetSlotIcon(Item item)
	{
		foreach (Slot slot in slots)
		{
			if (slot.IsEmpty())
			{
				slot.SetIcon(item);
				break;
			}
		}
	}
	// 選択されてるアイテムのみ選択中アイコンを表示
	public void OnSelected(int position)
	{
		for(int i = 0; i < slots.Length; i++)
		{
			slots[i].HideSelectedIcon();
		}
		slots[position].ShowSelectedIcon();
		selectedItem = slots[position].GetItem();
		selectedSlot = slots[position];

	}

	public Item GetSelectedItem()
	{
		return selectedItem;
	}

	// アイテムを使用することを試みる　アイテムが使用できるなら使用する
	public bool TryUseItem(Item.ITEM_TYPE itemType)
	{
		if(selectedItem == null)
		{
			return false;
		}if(selectedItem.itemType == itemType)
		{
			selectedSlot.HideSelectedIcon();
			selectedSlot.SetIcon(null);
			return true;
		
		}
		return false;
	}


}
