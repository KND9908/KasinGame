using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textbuttonprogram : MonoBehaviour
{
    GameObject Text;
    CsvReader CSV;
    [SerializeField] GameObject anothersentakusibtn;
    [SerializeField] GameObject Sentakusibtn1;
    texthyouzi TXT;
    [SerializeField] int returnsuuti = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        CSV = Text.GetComponent<CsvReader>();
        TXT = Text.GetComponent<texthyouzi>();
        //デフォルトは非表示
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calltextbutton(string str1)
    {
        //引数のstr1をボタンの文字列に設定　rtn1も返り値にする
        //もし選択肢が他にもあるなら同様の処理をボタン2に設定
        Sentakusibtn1.GetComponentInChildren<Text>().text = str1;
        this.gameObject.SetActive(true);
        //非表示のボタンを表示する
    }

    public void pushbutton()
    {
        //texthyouziにreturnflagをあげる
        this.gameObject.SetActive(false);
        anothersentakusibtn.SetActive(false);
        //値を渡す
        while (TXT.syoriLock == true)
        {

        }
        TXT.setsentakusi1flag(returnsuuti);
        TXT.CleandisplayText();
        TXT.textStop = false;
    }
}
