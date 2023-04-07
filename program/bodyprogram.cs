using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyprogram : MonoBehaviour
{
    public SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite MBigOpen;
    public Sprite MniyariOpen;
    public Sprite MawaOpen;
    public Sprite MsankakuOpen;
    public Sprite Mnewsankaku;
    public Sprite Mniyaniya;
    public Sprite Mmorebig;
    public Sprite Mbou;
    public Sprite Mnikoniko;
    public Sprite Mee;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMouth(int count)
    {
        switch (count)
        {
            case 1:
                OpenMouthBig();
                break;
            case 2:
                OpenMouthniyari();
                break;
            case 3:
                OpenMouthawa();
                break;
            case 4:
                OpenMouthsankaku();
                break;
            case 5:
                OpenMouthnewsankaku();
                break;
            case 6:
                OpenMouthNiyaniya();
                break;
            case 7:
                OpenMouthmorebig();
                break;
            case 8:
                OpenMouthbou();
                break;
            case 9:
                OpenMouthnikoniko();
                break;
            case 10:
                OpenMouthee();
                break;
            default:
                break;
        }
    }

    void OpenMouthBig()
    {
        Debug.Log("OpenMouthBig");
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        MainSpriteRenderer.sprite = MBigOpen;
    }

    void OpenMouthniyari()
    {
        Debug.Log("OpenMouthniyari");
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        MainSpriteRenderer.sprite = MniyariOpen;
    }

    void OpenMouthawa()
    {
        Debug.Log("OpenMouthawa");
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        MainSpriteRenderer.sprite = MawaOpen;
    }

    void OpenMouthsankaku()
    {
        Debug.Log("OpenMouthsankaku");
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        MainSpriteRenderer.sprite = MsankakuOpen;
    }

    void OpenMouthnewsankaku()
    {
        MainSpriteRenderer.sprite = Mnewsankaku;
    }

    void OpenMouthNiyaniya()
    {
        MainSpriteRenderer.sprite = Mniyaniya;
    }

    void OpenMouthmorebig()
    {
        MainSpriteRenderer.sprite = Mmorebig;
    }

    void OpenMouthbou()
    {
        MainSpriteRenderer.sprite = Mbou;
    }

    void OpenMouthnikoniko()
    {
        MainSpriteRenderer.sprite = Mnikoniko;
    }

    void OpenMouthee()
    {
        MainSpriteRenderer.sprite = Mee;
    }
}
