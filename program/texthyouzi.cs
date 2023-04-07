using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texthyouzi : MonoBehaviour
{
    //public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    int displayTextSpeed;
    int talkcount;
    bool readsyorimati = false;
    public bool click;
    public bool textStop;//追加
    public bool syoriLock;//割り込み処理させないフラグ
    bool mouthflag = true;//口のパクパクフラグ
    bool colorchange = false;
    bool FadeIn = false;
    bool FadeOut = false;
    float flametimer = 0.0f;
    GameObject mouth;
    bodyprogram BD;
    GameObject eye;
    Eyeprogram ED;
    GameObject mayuge;
    Mayugeprogram MYD;
    GameObject Text;
    CsvReader CSV;
    GameObject selectpanel;
    GameObject hukidasi;
    GameObject munehantei;
    GameObject Lovemeter;
    lovemeter LM;
    Effectprogram Effect;
    FadeOut FD;
    GameObject btntalk;
    btntalkcontrol BTNCTRL;
    GameObject Sentakusibtn1;
    GameObject Sentakusibtn2;
    textbuttonprogram txtbtn;
    textbuttonprogram txtbtn2;
    public float red, green, blue, alfa;   //パネルの色、不透明度を管理(ほんとは初期値入れた方がいいけど）
    public List<string> texts = new List<string>();
    public List<int> mouths = new List<int>();
    public List<int> eyes = new List<int>();
    public List<int> mayuges = new List<int>();
    List<int> listEffectase = new List<int>();
    List<int> listEffectakarame = new List<int>();
    List<int> listEffectdaidaihoho = new List<int>();
    List<int> listEffectkaomakka = new List<int>();
    List<int> listEffectwaruikage = new List<int>();
    List<string> sentakusi1 = new List<string>();
    List<string> sentakusi2 = new List<string>();
    int sentakusiflag = 0;
    List<int> returnflag = new List<int>();
    // Start is called before the first frame update
    void Start()
    {//初期設定
        Sentakusibtn1 = GameObject.Find("sentakusi1");
        Sentakusibtn1.SetActive(false);
        Sentakusibtn2 = GameObject.Find("sentakusi2");
        Sentakusibtn2.SetActive(false);
        txtbtn = Sentakusibtn1.GetComponent<textbuttonprogram>();
        txtbtn2 = Sentakusibtn2.GetComponent<textbuttonprogram>();
        Lovemeter = GameObject.Find("txt_level");
        LM = Lovemeter.GetComponent<lovemeter>();
        btntalk = GameObject.Find("btn_talk");
        BTNCTRL = btntalk.GetComponent<btntalkcontrol>();
        BTNCTRL.chgvisible(false);
        mouth = GameObject.Find("mouth");
        BD = mouth.GetComponent<bodyprogram>();
        eye = GameObject.Find("eye");
        ED = eye.GetComponent<Eyeprogram>();
        mayuge = GameObject.Find("mayuge");
        MYD = mayuge.GetComponent<Mayugeprogram>();
        Text = GameObject.Find("Text");
        CSV = Text.GetComponent<CsvReader>();
        //selectpanel = GameObject.Find("selectpanel");
        //FD = selectpanel.GetComponent<FadeOut>();
        hukidasi = GameObject.Find("Capsule");
        Effect = this.GetComponent<Effectprogram>();
        munehantei = GameObject.Find("munehantei");
        //while (readsyorimati == false)
        //{
        //    int count = 0;
        //    count++;
        //    if (count == 100)
        //    {
        //        break;
        //    }
        //}
        Debug.Log("readsyorimati::" + readsyorimati);
        texts = CSV.SetSerihu();
        mouths = CSV.SetMouth();
        eyes = CSV.SetEye();
        mayuges = CSV.SetMayuge();
        listEffectase = CSV.SetEffectase();
        listEffectakarame = CSV.SetEffectakarame();
        listEffectdaidaihoho = CSV.SetEffectdaidaihoho();
        listEffectkaomakka = CSV.SetEffectkaomakka();
        listEffectwaruikage = CSV.SetEffectwaruikage();
        sentakusi1 = CSV.Setreturntext1();
        sentakusi2 = CSV.Setreturntext2();
        returnflag = CSV.Setreturnflag();
        red = hukidasi.GetComponent<Renderer>().material.color.r;
        green = hukidasi.GetComponent<Renderer>().material.color.g;
        blue = hukidasi.GetComponent<Renderer>().material.color.b;
        alfa = hukidasi.GetComponent<Renderer>().material.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        /////吹き出しの表示非表示管理（今はつかわない　なんか思いついたら使う）
        //Debug.Log("現在のテキスト表示のalfaの値　＝　" + hukidasi.GetComponent<Renderer>().material.color.a);

        //Debug.Log("colorchange" + colorchange);
        //if (FadeIn == true && colorchange == true)
        //{
        //    Debug.Log("startfadein");
        //    Debug.Log("テキスト表示のalfaの値　＝　" + hukidasi.GetComponent<Renderer>().material.color.a);
        //    FD.StartFadeIn();

        //}
        //else if (FadeOut == true && colorchange == true)
        //{
        //    Debug.Log("startfadeout");
        //    FD.StartFadeOut();
        //}
        //Debug.Log("nowflametimer::" + flametimer);
        Debug.Log("readsyorimati::" + readsyorimati);
            if (textStop == false)//追加
        {//追加
            flametimer = 0.0f;
            syoriLock = true;
            munehantei.SetActive(false);
            displayTextSpeed++;
            if (displayTextSpeed % 4 == 0)
            {
                talkcount++;
                //if (talkcount % 5 == 0 && textCharNumber != texts[textNumber].Length)
                //{
                //    //口パクパク処理（後ほど使用）
                //    //if (mouthflag == true)
                //    //{
                //    //    BD.OpenMouthBig();
                //    //    //口開ける
                //    //    mouthflag = false;
                //    //}
                //    //else
                //    //{
                //    //    BD.OpenMouthniyari();
                //    //    //口閉じる
                //    //    mouthflag = true;
                //    //}
                //}
                //if (sentakusiflag == 0 && returnflag[textNumber] != 0)
                //{
                //    while (returnflag[textNumber] != 0 && textNumber != texts.Count - 1)
                //    {
                //        textNumber++;
                //    }
                //}
                if (sentakusiflag != 0)//ボタンからの返答がなにかしらあったら
                {
                    //displayText = "";
                    Debug.Log("returnflag:"+ returnflag[textNumber] + "sentakusiflag" + sentakusiflag);
                    if (textNumber != texts.Count - 1)
                    {
                        if (sentakusiflag != returnflag[textNumber] && returnflag[textNumber] != 0)//今読んでるワードリストが選択肢の返答として正しくない場合
                        {
                            while (returnflag[textNumber] != sentakusiflag)
                            {
                                textNumber++;
                                if (returnflag[textNumber] == 0)
                                {
                                    Debug.Log("ここはきてる３？");
                                    sentakusiflag = 0;
                                    break;
                                }
                            }
                            if (returnflag[textNumber] == 0)
                            {
                                sentakusiflag = 0;
                            }
                        }
                        else if (textNumber != texts.Count - 1)//選択しによる言葉のデータが連続していない場合
                        {
                            if (sentakusiflag != returnflag[textNumber + 1])
                            {
                                if (returnflag[textNumber + 1] == 0)
                                {
                                    Debug.Log("ここはきてる4？");
                                    sentakusiflag = 0;
                                }
                            }
                        }
                        else
                        {
                            Debug.Log("ここはきてる5？");
                            sentakusiflag = 0;
                        }
                    }
                }
                Debug.Log("現在のtextnumber"+textNumber);
                BD.SetMouth(mouths[textNumber]);
                ED.SetEye(eyes[textNumber]);
                MYD.SetMayuge(mayuges[textNumber]);
                Debug.Log("listEffectase[textNumber]=" + listEffectase[textNumber]);
                Effect.ChgEffectase(listEffectase[textNumber]);
                Effect.ChgEffectakarame(listEffectakarame[textNumber]);
                Effect.ChgEffectdaidaihoho(listEffectdaidaihoho[textNumber]);
                Effect.Chgkaomakka(listEffectkaomakka[textNumber]);
                Effect.Chgwaruikage(listEffectwaruikage[textNumber]);
                if (textCharNumber != texts[textNumber].Length)//一文字ずつ文字を追加する処理のif
                {
                    displayText = displayText + texts[textNumber][textCharNumber];
                    textCharNumber = textCharNumber + 1;
                }
                else
                {
                    if (sentakusi1[textNumber] != "0")//もしpushボタン表示処理が組み込まれているテキストを読んだら
                    {
                        if (click == true)
                        {
                                //displayText = "";
                                //textCharNumber = 0;
                            txtbtn.calltextbutton(sentakusi1[textNumber]);
                            Sentakusibtn1.SetActive(true);
                            if (sentakusi2[textNumber] != "0")//もしpushボタン表示処理が組み込まれているテキストを読んだら
                            {
                                txtbtn2.calltextbutton(sentakusi2[textNumber]);
                                Sentakusibtn2.SetActive(true);
                            }
                            textNumber++;
                            textCharNumber = 0;
                            textStop = true;//追加
                        }
                        Debug.Log("clickflag:" + click);
                    }
                    else
                    {
                        if (textNumber != texts.Count - 1)
                        {
                            if (click == true)
                            {
                                Debug.Log("ここきてる？");
                                displayText = "";
                                textCharNumber = 0;
                                textNumber = textNumber + 1;
                            }
                        }
                        else//追加
                        {//追加
                         //                        if (click == true)//追加
                         //                        {//読み込んだCSVの内容がこれで終わりの時
                         //displayText = "";//追加
                            Debug.Log("ここくる？");
                            textCharNumber = 0;//追加
                            textStop = true;//追加
                            BTNCTRL.chgvisible(true);
                            munehantei.SetActive(true);
                            textNumber = 0;

                            //                       }//追加
                        }//追加
                    }
                }
                this.GetComponent<Text>().text = displayText;
                click = false;
            }

        }//追加
        syoriLock = false;
        flametimer += Time.deltaTime;
        if (flametimer >= 20.0f)
        {
            flametimer = 0.0f;
            CSV.randomchat(@"C:\kasingame\csv\hima.csv", 1, 9);
            getCsvText();
            LM.chargelevel(50);
        }
    }

    public void setsentakusi1flag(int sentakusi)
    {
        sentakusiflag = sentakusi;
        Debug.Log("setsentakusi:"+sentakusi);
    }

    public void setsyorimatiflag(bool flag)
    {
        readsyorimati = flag;
    }

    public void Setcolorchange(bool chgflag)
    {
        colorchange = chgflag;
        Debug.Log("setcolorchange");
    }

    public bool Getcolorchange()
    {
        return colorchange;
    }

    public void SetFadeIn(bool UseFadeIn)
    {
        FadeIn = UseFadeIn;
    }

    public void SetFadeOut(bool UseFadeOut)
    {
        FadeOut = UseFadeOut;
    }
    public void SettextStop(bool flag)
    {//割り込み処理用テキストリード位置リセット処理
        textStop = flag;
        while (syoriLock == true)
        {
            Debug.Log("setcolorchange");
        }
        displayText = "";
        textNumber = 0;
        textCharNumber = 0;
    }

    public void CleandisplayText()
    {
        displayText = "";
    }

    public void Setalfa(float Red,float Green,float Blue,float Alfa)
    {
        Debug.Log("Setalfa:"+Alfa);
        alfa = Alfa;
        hukidasi.GetComponent<Renderer>().material.color = new Color(Red, Green, Blue, Alfa);
    }

    //csvから読み込んだテキストの内容をcsvreaderから取得する処理
    public void getCsvText()
    {
        displayText = "";//追加
        //CSV.randomchat();
        //texts.Clear();
        //mouths.Clear();
        //eyes.Clear();
        //mayuges.Clear();
        //listEffectase.Clear();
        //listEffectakarame.Clear();
        //listEffectdaidaihoho.Clear();
        //listEffectkaomakka.Clear();
        //listEffectwaruikage.Clear();
        while (readsyorimati == false)
        {
            Debug.Log("処理待ち中");
        }
        readsyorimati = false;

        texts = CSV.SetSerihu();
        //Debug.Log("今のテキストの中身" + texts[0]);
        mouths = CSV.SetMouth();
        //Debug.Log("今のmouthの中身" + texts[0]);
        eyes = CSV.SetEye();
        mayuges = CSV.SetMayuge();
        listEffectase = CSV.SetEffectase();
        listEffectakarame = CSV.SetEffectakarame();
        listEffectdaidaihoho = CSV.SetEffectdaidaihoho();
        listEffectkaomakka = CSV.SetEffectkaomakka();
        listEffectwaruikage = CSV.SetEffectwaruikage();
        sentakusi1 = CSV.Setreturntext1();
        sentakusi2 = CSV.Setreturntext2();
        returnflag = CSV.Setreturnflag();
        textStop = false;
    }
}
