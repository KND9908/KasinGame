using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btntalkcontrol : MonoBehaviour
{
    GameObject TextCtrl;
    texthyouzi TEXTHYOUZI;
    CsvReader CSV;
    GameObject Lovemeter;
    lovemeter LM;
    // Start is called before the first frame update
    void Start()
    {
        //最初はしゃべるボタン非表示
        TextCtrl = GameObject.Find("Text");
        TEXTHYOUZI = TextCtrl.GetComponent<texthyouzi>();
        CSV = TextCtrl.GetComponent<CsvReader>();
        Lovemeter = GameObject.Find("txt_level");
        LM = Lovemeter.GetComponent<lovemeter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chgvisible(bool chg)
    {
        this.gameObject.SetActive(chg);
    }

    public void pushbtn()
    {
        //しゃべるボタン押下処理
        //割り込みまち
        TEXTHYOUZI.SettextStop(true);
        chgvisible(false);
        while (TEXTHYOUZI.textStop == false && TEXTHYOUZI.syoriLock == false)
        {

        }
        Debug.Log("pushbtntalk");
        CSV.randomchat(@"C:\kasingame\csv\random1.csv",1,9);
        TEXTHYOUZI.getCsvText();
        LM.chargelevel(100);
    }
}
