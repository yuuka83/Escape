using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Dial : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip dialAudioClip;
	[SerializeField] AudioClip clearAudioClip;
	[SerializeField] Sprite[] numberSprites;
	[SerializeField] Image[] currentNumberImages;
	int[] currentNumbers = { 0, 0, 0 ,0};
	[SerializeField] int[] correctNumbers = {9,5,6,4};

	public UnityEvent ClearedAction;

	public void OnClick(int pos)
	{
		UpdateNumber(pos);
		if (CheckAnswer())
		{
			Cleared();
		}
	}
	void UpdateNumber(int pos)
	{
		audioSource.PlayOneShot(dialAudioClip);
		if (currentNumbers[pos] < numberSprites.Length-1) {
			currentNumbers[pos]++;
		}
		else
		{
			currentNumbers[pos] = 0;
		}
		currentNumberImages[pos].sprite = numberSprites[currentNumbers[pos]];

	}
	bool CheckAnswer()
	{
		for(int i = 0; i < currentNumbers.Length; i++)
		{
			if(currentNumbers[i] != correctNumbers[i])
			{
				return false;
			}
		}
		return true;
	}
	void Cleared()
	{
		audioSource.PlayOneShot(clearAudioClip);
		ClearedAction.Invoke();
	}

	
}
