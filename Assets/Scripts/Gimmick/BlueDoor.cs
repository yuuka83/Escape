using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoor : MonoBehaviour
{
	[SerializeField] GameObject blueDoor;
	[SerializeField] GameObject blueDoorOpen;

	public void OnOpenDoor()
	{
		blueDoor.SetActive(false);
		blueDoorOpen.SetActive(true);
	}
}
