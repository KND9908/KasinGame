using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mayugeprogram : MonoBehaviour
{
    public SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
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
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        MainSpriteRenderer.sprite = MayugeKamaboko;
    }

    void ChgKomari()
    {
        Debug.Log("ChgKomari");
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        MainSpriteRenderer.sprite = MayugeKomari;
    }

    void ChgSikame()
    {
        Debug.Log("ChgSikame");
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        MainSpriteRenderer.sprite = MayugeSikame;
    }

}
