using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinko : MonoBehaviour
{
	[SerializeField] GameObject kinkoClose;
	[SerializeField] GameObject kinkoCard;
	[SerializeField] GameObject kinkoOpen;
	[SerializeField] GameObject smallKinko;
	[SerializeField] GameObject smallKinkoCard;
	[SerializeField] GameObject smallKinkoOpen;

	public void OnClick()
	{
		bool hasCard = ItemBox.instance.TryUseItem(Item.ITEM_TYPE.CARD);
		if(hasCard == true)
		{
			kinkoClose.SetActive(false);
			kinkoCard.SetActive(true);
		}
	}

	public void OpenKinko()
	{
		kinkoCard.SetActive(false);
		kinkoOpen.SetActive(true);
	}
}
