using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bodypush : MonoBehaviour
{
    GameObject Text;
    GameObject munehantei;
    texthyouzi TXT;
    CsvReader CSV;
    bool munetalk = false;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        TXT = Text.GetComponent<texthyouzi>();
        CSV = Text.GetComponent<CsvReader>();
        munehantei = GameObject.Find("munehantei");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void textclick()
    {
        Debug.Log("textclick");
        TXT.click = true;
    }

    public void muneclick()
    {
        if (munetalk == false)
        {
            munetalk = true;
        }

        if (munetalk == true && TXT.textStop == true)
        {
            Debug.Log("mune");
            CSV.randomchat(@"C:\kasingame\csv\mune.csv",1,3); //Ç±ÇÍÇ©ÇÁãπópÇÃCSVçÏÇÈ
            TXT.click = true;
            TXT.getCsvText();
            munetalk = false;
        }
    }
}
