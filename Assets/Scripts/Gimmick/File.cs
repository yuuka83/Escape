using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class File : MonoBehaviour
{
    [SerializeField] GameObject hintCard;
    // ファイルを押したらヒントカードを表示する
    public void OnClickFile()
	{
        hintCard.SetActive(true);
	}
}
