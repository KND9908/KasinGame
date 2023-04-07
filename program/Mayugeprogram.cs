using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mayugeprogram : MonoBehaviour
{
    public SpriteRenderer MainSpriteRenderer;
    // public�Ő錾���Ainspector�Őݒ�\�ɂ���
    public Sprite MayugeKamaboko;
    public Sprite MayugeKomari;
    public Sprite MayugeSikame;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetMayuge(int count)
    {
        switch (count)
        {
            case 1:
                ChgKamaboko();
                break;
            case 2:
                ChgKomari();
                break;
            case 3:
                ChgSikame();
                break;
            default:
                break;
        }
    }

    void ChgKamaboko()
    {
        Debug.Log("ChgKamaboko");
        // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
        MainSpriteRenderer.sprite = MayugeKamaboko;
    }

    void ChgKomari()
    {
        Debug.Log("ChgKomari");
        // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
        MainSpriteRenderer.sprite = MayugeKomari;
    }

    void ChgSikame()
    {
        Debug.Log("ChgSikame");
        // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
        MainSpriteRenderer.sprite = MayugeSikame;
    }

}
