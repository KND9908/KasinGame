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
        //���x���ƌo���l�͕ω����������琏���I�[�g�Z�[�u�ɂ���
    }

    //����̃��x���ɓ��B�����Ƃ��ɍs���鏈��
    void eventtalk()
    {

    }

    void viewparam()
    {
        //�Ȃ񂩕��i��\���ɂ��ĂČo���l��ɓ��ꂽ�Ƃ������U�ꕝ�\�����Ă҂����Ă���ď������炢�����
    }
    //�o���l�擾����
    public void chargelevel(int exp)
    {
        nowexp = nowexp + exp;
        totalexp = totalexp + exp;
        //���x���A�b�v����
        if (mokuhyouexp <= nowexp)
        {
            level++;
            nowexp = nowexp - mokuhyouexp;
            mokuhyouexp = mokuhyouexp + explunk * level;
        }
    }

    void SaveLovelevel()
    {
        //�Z�[�u����
    }

    void angrykozi(int exp)
    {
        //���G�����肵�����̃o�b�h�C�x���g�p�o���l����
        nowexp = nowexp - exp;
        if (nowexp < 0)
        {
            nowexp = 0;
        }
    }
}
