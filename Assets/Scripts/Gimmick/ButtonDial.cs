using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonDial : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip dialSound;
	[SerializeField] AudioClip clearSound;
	[SerializeField] int[] correctNumbers;
    List<int> currentNumbers = new List<int>();
	Animator animator;

	private void Start()
	{

		animator = this.gameObject.GetComponent<Animator>();
	}

	public UnityEvent ClearedAction;
    public void OnReset()
	{
		animator.Play("buttons0Push",0,0);
		currentNumbers.Clear();
	}

	public void OnClick(int pos) {
		audioSource.PlayOneShot(dialSound);

		if (pos == 0)
		{
			animator.Play("buttons1Push",0,0);
		}
		if (pos == 1)
		{
			animator.Play("buttons2Push",0,0);
		}
		if (pos == 2)
		{
			animator.Play("buttons3Push",0,0);
		}
		currentNumbers.Add(pos);
		if (CheckAnswer()) { Cleared(); };
		
	}

	bool CheckAnswer()
	{
		//DebugDial();
		if (currentNumbers.Count != correctNumbers.Length)
		{
			return false;
		}
		for(int i = 0; i < currentNumbers.Count; i++)
		{
			if(currentNumbers[i] != correctNumbers[i])
			{
				return false;
			}
		}
		return true;
	}

	void DebugDial()
	{
		for(int i = 0; i < currentNumbers.Count; i++)
		{
			Debug.Log(currentNumbers[i]);
		}
	}
	void Cleared()
	{
		audioSource.PlayOneShot(clearSound);
		ClearedAction.Invoke();
	}
}
