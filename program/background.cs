using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class background : MonoBehaviour
{
    DateTime dt;
    public SpriteRenderer MainSpriteRenderer;
    // public�Ő錾���Ainspector�Őݒ�\�ɂ���
    public Sprite haikei_hiru;
    public Sprite haikei_yoru;
    // Start is called before the first frame update
    void Start()
    {
        dt = DateTime.Now;
        //���̎���
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
