using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSceneManager : MonoBehaviour
{

	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip clearSound;
	private void Start()
	{
		audioSource.PlayOneShot(clearSound);
	}
	public void OnClickRetry()
	{
		SceneManager.LoadScene("Main");
	}
}
