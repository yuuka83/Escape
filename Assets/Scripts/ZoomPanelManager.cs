using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomPanelManager : MonoBehaviour
{
    [SerializeField] Slot slot;
    [SerializeField] GameObject zoomPanel;
    [SerializeField] GameObject mainPanel;

	private void Start()
	{

	}
	// 選択された状態でズームボタンを押したらmainPanelに選択したアイテムを表示する
	public void OnClickZoom()
	{

        if (!slot.IsEmpty())
        {
            zoomPanel.SetActive(true);
            mainPanel.GetComponent<Image>().sprite = slot.GetItem().sprite;
             //mainPanel.GetComponent<Image>().sprite = ItemBox.instance.GetSelectedItem().sprite;
        }

	}
    // Closeボタンが押されたらZoomPanelを非表示にする
    public void OnClickClose()
	{
        zoomPanel.SetActive(false);
	}
}
