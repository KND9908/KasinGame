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
        //�f�t�H���g�͔�\��
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calltextbutton(string str1)
    {
        //������str1���{�^���̕�����ɐݒ�@rtn1���Ԃ�l�ɂ���
        //�����I���������ɂ�����Ȃ瓯�l�̏������{�^��2�ɐݒ�
        Sentakusibtn1.GetComponentInChildren<Text>().text = str1;
        this.gameObject.SetActive(true);
        //��\���̃{�^����\������
    }

    public void pushbutton()
    {
        //texthyouzi��returnflag��������
        this.gameObject.SetActive(false);
        anothersentakusibtn.SetActive(false);
        //�l��n��
        while (TXT.syoriLock == true)
        {

        }
        TXT.setsentakusi1flag(returnsuuti);
        TXT.CleandisplayText();
        TXT.textStop = false;
    }
}
