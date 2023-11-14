using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip drawOpenSound;
    [SerializeField] AudioClip drawClosingSound;
    [SerializeField] AudioClip drawClosedSound;

    // 矢印をクリックしたらパネルを移動する
    // 矢印を各方向のみ表示する
    public enum PANEL_TYPE
	{
        PANEL0,
        PANEL1,
        PANEL2,
        PANEL3,
        PANEL_PC,
        PANEL_KINKO,
        PANEL_DUSTBOX,
        PANEL_BUTTONS,
        PANEL_TYOKINBAKO,
        PANEL_RED_BOURD,
        PANEL_BLUE_BOURD_LOCK,
        PANEL_DRAW,
        PANEL_DRAW_ONE_OPEN,
        PANEL_DRAW_TWO_OPEN,
        PANEL_DRAW_THREE_OPEN,

    }

    public PANEL_TYPE currentPanel = PANEL_TYPE.PANEL0;

    [SerializeField] GameObject rightArrow;
    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject backArrow;

    bool hasKey = false;

    // 右矢印をクリックした時に実行する
    public void OnClickRightArrow()
	{
        currentPanel++;
        if(currentPanel == PANEL_TYPE.PANEL3+1){
            currentPanel = PANEL_TYPE.PANEL0;
		}
        ShowPanel(currentPanel);

    }


    

    public void OnClickLeftArrow()
	{
        currentPanel--;
        if(currentPanel == PANEL_TYPE.PANEL0-1)
		{
            currentPanel = PANEL_TYPE.PANEL3;
		}
        ShowPanel(currentPanel);
    }

    public void OnClickBackArrow()
	{
        activateSideArrow();
        if (currentPanel == PANEL_TYPE.PANEL_KINKO)
		{
            currentPanel = PANEL_TYPE.PANEL2;
		}
        if (currentPanel == PANEL_TYPE.PANEL_DUSTBOX || currentPanel == PANEL_TYPE.PANEL_BUTTONS)
        {
            currentPanel = PANEL_TYPE.PANEL3;
        }
        if (currentPanel == PANEL_TYPE.PANEL_PC || currentPanel == PANEL_TYPE.PANEL_DRAW || currentPanel == PANEL_TYPE.PANEL_DRAW_ONE_OPEN || currentPanel == PANEL_TYPE.PANEL_DRAW_TWO_OPEN || currentPanel == PANEL_TYPE.PANEL_DRAW_THREE_OPEN)
        {
            currentPanel = PANEL_TYPE.PANEL0;
        }
        if (currentPanel == PANEL_TYPE.PANEL_TYOKINBAKO)
        {
            currentPanel = PANEL_TYPE.PANEL2;
        }
        if (currentPanel == PANEL_TYPE.PANEL_RED_BOURD || currentPanel == PANEL_TYPE.PANEL_BLUE_BOURD_LOCK)
        {
            currentPanel = PANEL_TYPE.PANEL3;
        }
        ShowPanel(currentPanel);
    }

    public void OnClickPC()
	{
        //
        currentPanel = PANEL_TYPE.PANEL_PC;
        ShowPanel(currentPanel);
        activateBackArrow();
    }

    public void OnClickDustBox()
	{
        currentPanel = PANEL_TYPE.PANEL_DUSTBOX;
        ShowPanel(currentPanel);
        activateBackArrow();
    }

    public void OnCkickKinko()
	{
        currentPanel = PANEL_TYPE.PANEL_KINKO;
        ShowPanel(currentPanel);
        activateBackArrow();
    }

    public void OnClickButtons()
	{
        currentPanel = PANEL_TYPE.PANEL_BUTTONS;
        ShowPanel(currentPanel);
        activateBackArrow();
    }

    public void OnClickTyokinbako()
    {
        currentPanel = PANEL_TYPE.PANEL_TYOKINBAKO;
        activateBackArrow();
        ShowPanel(currentPanel);
    }
    public void OnClickRedBourd()
    {
        currentPanel = PANEL_TYPE.PANEL_RED_BOURD;
        activateBackArrow();
        ShowPanel(currentPanel);
    }
    public void OnClickBlueBourdLock()
    {
        currentPanel = PANEL_TYPE.PANEL_BLUE_BOURD_LOCK;
        activateBackArrow();
        ShowPanel(currentPanel);
    }

    public void OnClickDraw()
	{
        currentPanel = PANEL_TYPE.PANEL_DRAW;
        activateBackArrow();
        ShowPanel(currentPanel);
    }

    // 一段目の閉まっている引き出しを押したら
    public void OnClickOneDraw()
    {
        audioSource.PlayOneShot(drawOpenSound);
        currentPanel = PANEL_TYPE.PANEL_DRAW_ONE_OPEN;
        activateBackArrow();
        ShowPanel(currentPanel);
    }
    // あいている引き出しを押したら
    public void OnClickOpenDraw()
    {
        audioSource.PlayOneShot(drawClosingSound);
        currentPanel = PANEL_TYPE.PANEL_DRAW;
        activateBackArrow();
        ShowPanel(currentPanel);
    }
    // 二段目の閉まっている引き出しを押したら
    public void OnClickTwoDraw()
    {
        audioSource.PlayOneShot(drawOpenSound);
        currentPanel = PANEL_TYPE.PANEL_DRAW_TWO_OPEN;
        activateBackArrow();
        ShowPanel(currentPanel);
    }
    // 三段目の閉まっている引き出しを
	// 鍵を持っている状態で押したら または 鍵をすでに使用していたら
    public void OnClickThreeDraw()
    {
        hasKey = ItemBox.instance.TryUseItem(Item.ITEM_TYPE.KEY);
        if (hasKey == true)
        {
            audioSource.PlayOneShot(drawOpenSound);
            currentPanel = PANEL_TYPE.PANEL_DRAW_THREE_OPEN;
            activateBackArrow();
            ShowPanel(currentPanel);
		}
		else
		{
            audioSource.PlayOneShot(drawClosedSound);
        }
    }
    // パネルに応じた位置に移動する
    void ShowPanel(PANEL_TYPE panel)
    {
        if (panel == PANEL_TYPE.PANEL0)
        {
            transform.localPosition = new Vector2(0, 0);
        }
        if (panel == PANEL_TYPE.PANEL1)
        {
            transform.localPosition = new Vector2(-2000, 0);
        }
        if (panel == PANEL_TYPE.PANEL2)
        {
            transform.localPosition = new Vector2(0, 1500);
        }
        if (panel == PANEL_TYPE.PANEL3)
        {
            transform.localPosition = new Vector2(-2000, 1500);
        }
        if (panel == PANEL_TYPE.PANEL_KINKO)
        {
            transform.localPosition = new Vector2(0, 3000);

        }
        if (panel == PANEL_TYPE.PANEL_DUSTBOX)
        {
            transform.localPosition = new Vector2(-2000, 3000);

        }
        if (panel == PANEL_TYPE.PANEL_KINKO)
        {
            transform.localPosition = new Vector2(0, 3000);

        }
        if (panel == PANEL_TYPE.PANEL_PC)
        {
            transform.localPosition = new Vector2(0, 4500);
        }
        if (panel == PANEL_TYPE.PANEL_BUTTONS)
        {
            transform.localPosition = new Vector2(-2000, 4500);
        }
        if (panel == PANEL_TYPE.PANEL_TYOKINBAKO)
        {
            transform.localPosition = new Vector2(0, 6000);
        }
        if (panel == PANEL_TYPE.PANEL_RED_BOURD)
        {
            transform.localPosition = new Vector2(-2000, 6000);
        }
        if (panel == PANEL_TYPE.PANEL_BLUE_BOURD_LOCK)
        {
            transform.localPosition = new Vector2(0, 7500);
        }
        if (panel == PANEL_TYPE.PANEL_DRAW)
        {
            transform.localPosition = new Vector2(-4000, 0);
        }
        if (panel == PANEL_TYPE.PANEL_DRAW_ONE_OPEN)
        {
            transform.localPosition = new Vector2(-6000, 0);
        }
        if (panel == PANEL_TYPE.PANEL_DRAW_TWO_OPEN)
        {
            transform.localPosition = new Vector2(-4000, 1500);
        }
        if (panel == PANEL_TYPE.PANEL_DRAW_THREE_OPEN)
        {
            transform.localPosition = new Vector2(-6000, 1500);
        }

    }

    void activateBackArrow()
	{
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(true);

    }

    void activateSideArrow()
	{
        rightArrow.SetActive(true);
        leftArrow.SetActive(true);
        backArrow.SetActive(false);
    }

}
