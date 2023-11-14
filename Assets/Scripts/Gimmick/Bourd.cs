using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bourd : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip breakSound;
	[SerializeField] GameObject smallRedBourd;
    public void OnClickThis()
	{
		// ドライバーを持っていたら消える
		bool hasdriver = ItemBox.instance.TryUseItem(Item.ITEM_TYPE.DRIVER);
		if(hasdriver == true)
		{
			audioSource.PlayOneShot(breakSound);
			this.gameObject.SetActive(false);
			smallRedBourd.SetActive(false);
		}
	}

}
