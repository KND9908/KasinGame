using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //パネルのイメージを操作するのに必要

public class FadeOut : MonoBehaviour
{
    float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理

    public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
    public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ
    GameObject Text;
    texthyouzi TXT;
    GameObject hukidasi;

    Image fadeImage;                //透明度を変更するパネルのイメージ

    // Start is called before the first frame update
    void Start()
    {
        fadeImage = GetComponent<Image>();
        //テキストオブジェクトの表示非表示切り替え判定
        hukidasi = GameObject.Find("hukidasi");
        Text = GameObject.Find("Text");
        TXT = Text.GetComponent<texthyouzi>();
        red = hukidasi.GetComponent<Renderer>().material.color.r;
        green = hukidasi.GetComponent<Renderer>().material.color.g;
        blue = hukidasi.GetComponent<Renderer>().material.color.b;
        alfa = hukidasi.GetComponent<Renderer>().material.color.a;
    }

    // Update is called once per frame
    void Update()
    {
 //       if (isFadeIn)
 //       {
 //           StartFadeIn();
 //       }
 //
 //       if (isFadeOut)
 //       {
 //           StartFadeOut();
 //       }
    }

    public void VisibleChg()
    {
        if (TXT.Getcolorchange() == false)
        {
            Debug.Log("Visiblechange");
            TXT.Setcolorchange(true);
            if (hukidasi.GetComponent<Renderer>().material.color.a >= 1)
            {
                TXT.SetFadeIn(true);
            }else if (hukidasi.GetComponent<Renderer>().material.color.a <= 0)
            {
                TXT.SetFadeOut(true);
            }
        }
    }

   public void StartFadeIn()
    {
        alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
        Debug.Log("alfaの値　＝　" + alfa);
        TXT.Setalfa(red, green, blue, alfa);                      //b)変更した不透明度パネルに反映する
        if (alfa <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            TXT.Setcolorchange(false);
            TXT.SetFadeIn(false);
        }
    }

   public void StartFadeOut()
    {
        //fadeImage.enabled = true;  // a)パネルの表示をオンにする
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        TXT.Setalfa(red, green, blue, alfa);               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            TXT.Setcolorchange(false);
            TXT.SetFadeOut(false);
        }
    }
    void SetAlpha()
    {
        TXT.alfa = alfa;
    }
}
