using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip usbClip;
	[SerializeField] GameObject usbPC;
	[SerializeField] GameObject smallPC;
	[SerializeField] GameObject smallUsbPC;

	// USBを持っていたらUSBのあるPCに変更する
	public void OnClickThis()
	{
		bool hasUSB = ItemBox.instance.TryUseItem(Item.ITEM_TYPE.USB);
		if(hasUSB == true)
		{
			audioSource.PlayOneShot(usbClip);
			usbPC.SetActive(true);
			this.gameObject.SetActive(false);
			smallPC.SetActive(false);
			smallUsbPC.SetActive(true);
		}
	}
}
