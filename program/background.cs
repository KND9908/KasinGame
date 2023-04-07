using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class background : MonoBehaviour
{
    DateTime dt;
    public SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite haikei_hiru;
    public Sprite haikei_yoru;
    // Start is called before the first frame update
    void Start()
    {
        dt = DateTime.Now;
        //昼の時間
        if (dt.Hour >= 7 && dt.Hour <=16)
        {
            MainSpriteRenderer.sprite = haikei_hiru;
        }
        else
        {
            MainSpriteRenderer.sprite = haikei_yoru;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
