using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Eyeprogram : MonoBehaviour
{
    public SpriteRenderer MainSpriteRenderer;
    // public�Ő錾���Ainspector�Őݒ�\�ɂ���
    public Sprite BCartoon;
    public Sprite Bniyari;
    public Sprite BNormal;
    public Sprite BTareme;
    public Sprite EyeHannme;
    public Sprite Eyemihiraki;
    public Sprite Eyenikoniko;
    public Sprite Eyemetuburi;
    Sprite KeepEye;
    int randomvalue;
    int loopwait = 0;
    System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        KeepEye = MainSpriteRenderer.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        loopwait++;
        if(loopwait % 10 == 0){
            loopwait = 0;
            randomvalue = rand.Next(0, 20);
            //Debug.Log(randomvalue);
            if (randomvalue == 9 && MainSpriteRenderer.sprite != Eyenikoniko)
            {
                MainSpriteRenderer.sprite = Eyemetuburi;
            }
            else
            {
                MainSpriteRenderer.sprite = KeepEye;
                KeepEye = MainSpriteRenderer.sprite;
            }
        }
    }
    public void SetEye(int count)
    {
        switch (count)
        {
            case 1:
                ChgBCartoon();
                break;
            case 2:
                ChgBniyari();
                break;
            case 3:
                ChgBNormal();
                break;
            case 4:
                ChgBTareme();
                break;
            case 5:
                ChgEyeHannme();
                break;
            case 6:
                ChgEyemihiraki();
                break;
            case 7:
                ChgEyenikoniko();
                break;
            case 8:
                ChgEyemetuburi();
                break;
            default:
                break;
        }
    }

    void ChgBCartoon()
    {
        Debug.Log("BCartoon");
        // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
        MainSpriteRenderer.sprite = BCartoon;
        KeepEye = MainSpriteRenderer.sprite;
    }

    void ChgBniyari()
    {
        Debug.Log("Bniyari");
        // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
        MainSpriteRenderer.sprite = Bniyari;
        KeepEye = MainSpriteRenderer.sprite;
    }

    void ChgBNormal()
    {
        Debug.Log("BNormal");
        // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
        MainSpriteRenderer.sprite = BNormal;
        KeepEye = MainSpriteRenderer.sprite;
    }

    void ChgBTareme()
    {
        Debug.Log("BTareme");
        // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
        MainSpriteRenderer.sprite = BTareme;
        KeepEye = MainSpriteRenderer.sprite;
    }

    void ChgEyeHannme()
    {
        MainSpriteRenderer.sprite = EyeHannme;
        KeepEye = MainSpriteRenderer.sprite;
    }

    void ChgEyemihiraki()
    {
        MainSpriteRenderer.sprite = Eyemihiraki;
        KeepEye = MainSpriteRenderer.sprite;
    }

    void ChgEyenikoniko()
    {
        MainSpriteRenderer.sprite = Eyenikoniko;
        KeepEye = MainSpriteRenderer.sprite;
    }

    void ChgEyemetuburi()
    {
        MainSpriteRenderer.sprite = Eyemetuburi;
        KeepEye = MainSpriteRenderer.sprite;
    }
}
