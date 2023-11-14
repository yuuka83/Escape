using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{

	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip startSound;
	public void OnClickStart()
	{
		audioSource.PlayOneShot(startSound);
		this.gameObject.SetActive(false);
	}
}
