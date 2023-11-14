using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip pickUpItemSound;
	public Item.ITEM_TYPE itemType;
	Item item;
	private void Start()
	{
		item = ItemGenerator.instance.Spawn(itemType);
	}

	public void OnClickItem()
	{
		audioSource.PlayOneShot(pickUpItemSound);
		ItemBox.instance.SetSlotIcon(item);
		this.gameObject.SetActive(false);
	}
}
