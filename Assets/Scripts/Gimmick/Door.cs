using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip doorOpenSound;
	[SerializeField] GameObject doorOpen;
	[SerializeField] Animator animator;
	public void OnClickThis()
	{
		bool hasKey = ItemBox.instance.TryUseItem(Item.ITEM_TYPE.KEY2);
		if (hasKey)
		{
			audioSource.PlayOneShot(doorOpenSound);
			animator.Play("doorOpenAnimation");
			doorOpen.SetActive(true);
			//this.gameObject.SetActive(false);
		}

	}
}
