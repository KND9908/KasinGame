using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lovemeter : MonoBehaviour
{
    int nowexp;
    int mokuhyouexp = 500;
    int level;
    int totalexp;
    int explunk = 30;
    GameObject TXTLEVEL;
    GameObject TXTEXP;
    GameObject Text;
    CsvReader CSV;
    string strexp;
    // Start is called before the first frame update
    void Start()
    {
        TXTLEVEL = GameObject.Find("txt_level");
        TXTEXP = GameObject.Find("txt_exp");
        Text = GameObject.Find("Text");
        CSV = Text.GetComponent<CsvReader>();

    }

    // Update is called once per frame
    void Update()
    {
        if (CSV.getfirstparamreadflag())
        {
            level = CSV.getlevel();
            nowexp = CSV.getnowexp();
            totalexp = CSV.gettotalexp();
            mokuhyouexp = CSV.getmokuhyouexp();
            CSV.finishparamread();
        }

        strexp = mokuhyouexp.ToString() +"/" + nowexp.ToString();
        this.GetComponent<Text>().text = level.ToString();
        TXTEXP.GetComponent<Text>().text = strexp;
        //レベルと経験値は変化があったら随時オートセーブにする
    }

    //特定のレベルに到達したときに行われる処理
    void eventtalk()
    {

    }

    void viewparam()
    {
        //なんか普段非表示にしてて経験値手に入れたときだけ振れ幅表示してぴかってやって消えたらいいよね
    }
    //経験値取得処理
    public void chargelevel(int exp)
    {
        nowexp = nowexp + exp;
        totalexp = totalexp + exp;
        //レベルアップ処理
        if (mokuhyouexp <= nowexp)
        {
            level++;
            nowexp = nowexp - mokuhyouexp;
            mokuhyouexp = mokuhyouexp + explunk * level;
        }
    }

    void SaveLovelevel()
    {
        //セーブ処理
    }

    void angrykozi(int exp)
    {
        //胸触ったりした時のバッドイベント用経験値処理
        nowexp = nowexp - exp;
        if (nowexp < 0)
        {
            nowexp = 0;
        }
    }
}
