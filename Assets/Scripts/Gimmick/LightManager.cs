using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip lightButtonSound;
	public enum LIGHT_STATE
	{
		ON,
		OFF
	}
	[SerializeField] GameObject disturbLightPanel;
	[SerializeField] GameObject[] darkPanels;
	[SerializeField] GameObject[] texts;
	[SerializeField] GameObject explainPanel;
	LIGHT_STATE lightState = LIGHT_STATE.ON;
	// スイッチを押したら文字が浮かび上がる
	public void OnClickThis()
	{
		audioSource.PlayOneShot(lightButtonSound);
		// 電気が消えていたら
		if (lightState == LIGHT_STATE.OFF)
		{
			// 電気をつける
			lightState = LIGHT_STATE.ON;
			LightOn();
		}
		else if(lightState == LIGHT_STATE.ON)
		{
			// 電気を消す
			LightOff();
			lightState = LIGHT_STATE.OFF;
		}
	}

	void LightOn()
	{
		foreach (GameObject panel in darkPanels)
		{
			panel.SetActive(false);
		}
		foreach (GameObject text in texts)
		{
			text.SetActive(false);
		}
	}

	void LightOff()
	{
		foreach (GameObject panel in darkPanels)
		{
			panel.SetActive(true);
		}
		foreach (GameObject text in texts)
		{
			text.SetActive(true);
		}
	}

	public void VarifyLight()
	{
		disturbLightPanel.SetActive(false);
		explainPanel.SetActive(true);
	}

	

}
