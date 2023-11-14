using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyokinbako : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip breakSound;
 	[SerializeField] GameObject tyokinbako;
	[SerializeField] GameObject tyokinbakoBreak;
	[SerializeField] GameObject smallTyokinbako;
	[SerializeField] GameObject smallTyokinbakoBreak;
	public void OnClickThis()
	{
		bool hasHammer = ItemBox.instance.TryUseItem(Item.ITEM_TYPE.HAMMER);
		if(hasHammer == true)
		{
			audioSource.PlayOneShot(breakSound);
			tyokinbako.SetActive(false);
			tyokinbakoBreak.SetActive(true);
			smallTyokinbako.SetActive(false);
			smallTyokinbakoBreak.SetActive(true);
		}
	}
}
