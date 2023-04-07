using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text;

public class CsvReader : MonoBehaviour
{
    GameObject TextCtrl;
    texthyouzi TEXTHYOUZI;
    List<string> listSerihu = new List<string>();
    List<int> listEye = new List<int>();
    List<int> listMouth = new List<int>();
    List<int> listMayuge = new List<int>();
    List<int> listMonnyou = new List<int>();
    List<int> listEffectase = new List<int>();
    List<int> listEffectakarame = new List<int>();
    List<int> listEffectdaidaihoho = new List<int>();
    List<int> listEffectkaomakka = new List<int>();
    List<int> listEffectwaruikage = new List<int>();
    List<int> readflag = new List<int>();
    List<string> listreturntext1 = new List<string>();
    List<string> listreturntext2 = new List<string>();
    List<int> returnflag = new List<int>();
    int level = 0;
    int nowexp = 0;
    int totalexp = 0;
    int mokuhyouexp = 0;
    int volume = 100;
    bool firstparamreadflag = false;
    StreamReader reader;
    DateTime dt;
    // Start is called before the first frame update
    void Start()
    {
        dt = DateTime.Now;
        Debug.Log(System.Environment.CurrentDirectory);
        TextCtrl = GameObject.Find("Text");
        TEXTHYOUZI = TextCtrl.GetComponent<texthyouzi>();
        //csvread(@"C:\kasingame\csv\sinario.csv");//イベント用シナリオテキスト表示（現在バグ修正中）
        helloText(dt.Hour);
        paramread();
        //btntalk = GameObject.Find("btn_talk");
        //while (!reader.EndOfStream)
        //{
        //    var line = reader.ReadLine();
        //    var values = line.Split(',');
        //    if (values[0] != "serihu")
        //    {
        //        Debug.Log("setcolorchange");
        //        listSerihu.Add(values[0]);
        //        listEye.Add(int.Parse(values[1]));
        //        listMouth.Add(int.Parse(values[2]));
        //        listMayuge.Add(int.Parse(values[3]));
        //        listMonnyou.Add(int.Parse(values[4]));
        //        listEffectase.Add(int.Parse(values[5]));
        //        listEffectakarame.Add(int.Parse(values[6]));
        //        listEffectdaidaihoho.Add(int.Parse(values[7]));
        //        listEffectkaomakka.Add(int.Parse(values[8]));
        //        listEffectwaruikage.Add(int.Parse(values[9]));
        //        foreach (var coloumn1 in listSerihu)
        //        {
        //            Console.WriteLine(coloumn1);
        //        }
        //    }
        //}
    }

    public void csvread(string readfile)
    {
        textclear();
        reader = new StreamReader(File.OpenRead(readfile));
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');
            if (values[0] != "serihu")
            {
                Debug.Log("readingfile" + readfile);
                if (values[0] != null)
                {
                    listSerihu.Add(values[0]);
                }
                Debug.Log(values[1]);
                listEye.Add(int.Parse(values[1]));
                listMouth.Add(int.Parse(values[2]));
                listMayuge.Add(int.Parse(values[3]));
                listMonnyou.Add(int.Parse(values[4]));
                listEffectase.Add(int.Parse(values[5]));
                listEffectakarame.Add(int.Parse(values[6]));
                listEffectdaidaihoho.Add(int.Parse(values[7]));
                listEffectkaomakka.Add(int.Parse(values[8]));
                listEffectwaruikage.Add(int.Parse(values[9]));
                readflag.Add(int.Parse(values[10]));
                if (values[12] == null)
                {
                    values[12] = "";
                }
                listreturntext1.Add(values[12]);
                if (values[13] == null)
                {
                    values[13] = "";
                }
                listreturntext2.Add(values[13]);
                if (values[14] == null)
                {
                    values[14] = "0";
                }
                returnflag.Add(int.Parse(values[14]));
                foreach (var coloumn1 in listSerihu)
                {
                    Console.WriteLine(coloumn1);
                }
            }
        }
        TEXTHYOUZI.setsyorimatiflag(true);
        Debug.Log("setsyorimatiflag");
    }

    void sinariokanri()
    {
        //シナリオ用の特殊台詞を話すときに使う関数
    }

    public void paramsave()
    {//書き込み処理（工事中）
        StreamWriter file = new StreamWriter(@"C:\kasingame\csv\config.csv", false, Encoding.GetEncoding("UTF-8"));
        file.WriteLine(string.Format("level,{0}", level));
        file.WriteLine(string.Format("nowexp,{0}", nowexp));
        file.WriteLine(string.Format("totalexp,{0}", totalexp));
        file.WriteLine(string.Format("mokuhyouexp,{0}", mokuhyouexp));
        file.WriteLine(string.Format("volume,{0}", volume));

        file.Close();
    }
    public int getlevel()
    {
        return level;
    }

    public int getnowexp()
    {
        return nowexp;
    }

    public int gettotalexp()
    {
        return totalexp;
    }

    public int getmokuhyouexp()
    {
        return mokuhyouexp;
    }

    public int getvolume()
    {
        return volume;
    }

    public void setlevel(int slevel)
    {
        level = slevel;
    }
    public void setnowexp(int snowexp)
    {
        nowexp = snowexp;
    }
    public void settotalexp(int stotalexp)
    {
        totalexp = stotalexp;
    }

    public void setmokuhyouexp(int smokuhyouexp)
    {
        mokuhyouexp = smokuhyouexp;
    }

    public void setvolume(int svolume)
    {
        volume = svolume;
    }

    void paramread()
    {//工事中
        reader = new StreamReader(File.OpenRead(@"C:\kasingame\csv\config.csv"));
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');
            Debug.Log(values[0]);
            switch (values[0])
            {
                case "level":
                    level = int.Parse(values[1]);
                    break;
                case "nowexp":
                    nowexp = int.Parse(values[1]);
                    break;
                case "totalexp":
                    totalexp = int.Parse(values[1]);
                    break;
                case "mokuhyouexp":
                    mokuhyouexp = int.Parse(values[1]);
                    break;
                case "volume":
                    volume = int.Parse(values[1]);
                    break;
                default:
                    break;
            }
        }
        firstparamreadflag = true;
    }
    public bool getfirstparamreadflag()
    {
        return firstparamreadflag;
    }

    public void finishparamread()
    {
        firstparamreadflag = false;
    }

    void helloText(int nowtime)
    {   
        textclear();
        reader = new StreamReader(File.OpenRead(@"C:\kasingame\csv\time.csv"));
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');
            if (values[0] != "serihu" && int.Parse(values[10]) >= nowtime)
            {
                Debug.Log("Openhellotext");
                listSerihu.Add(values[0]);
                listEye.Add(int.Parse(values[1]));
                listMouth.Add(int.Parse(values[2]));
                listMayuge.Add(int.Parse(values[3]));
                listMonnyou.Add(int.Parse(values[4]));
                listEffectase.Add(int.Parse(values[5]));
                listEffectakarame.Add(int.Parse(values[6]));
                listEffectdaidaihoho.Add(int.Parse(values[7]));
                listEffectkaomakka.Add(int.Parse(values[8]));
                listEffectwaruikage.Add(int.Parse(values[9]));
                readflag.Add(int.Parse(values[10]));
                if (values[12] == null)
                {
                    values[12] = "";
                }
                listreturntext1.Add(values[12]);
                if (values[13] == null)
                {
                    values[13] = "";
                }
                listreturntext2.Add(values[13]);
                if (values[14] == null)
                {
                    values[14] = "0";
                }
                returnflag.Add(int.Parse(values[14]));
                foreach (var coloumn1 in listSerihu)
                {
                    Console.WriteLine(coloumn1);
                }
                break;
            }
        }
    }
    //一番最初に喋るときの処理
    void firsttalk()
    {

    }

    void textclear()
    {
        listSerihu.Clear();
        listEye.Clear();
        listMouth.Clear();
        listMayuge.Clear();
        listMonnyou.Clear();
        listEffectase.Clear();
        listEffectakarame.Clear();
        listEffectdaidaihoho.Clear();
        listEffectkaomakka.Clear();
        listEffectwaruikage.Clear();
        readflag.Clear();
        listreturntext1.Clear();
        listreturntext2.Clear();
        returnflag.Clear();
    }

    public List<string> SetSerihu()
    {
     //   Debug.Log("受け渡しているテキストの中身" + listSerihu[1]);
        return listSerihu;
    }

    public List<int> SetEye()
    {
        return listEye;
    }

    public List<int> SetMouth()
    {
        return listMouth;
    }

    public List<int> SetMayuge()
    {
        return listMayuge;
    }

    public List<int> SetEffectase()
    {
        return listEffectase;
    }

    public List<int> SetEffectakarame()
    {
        return listEffectakarame;
    }

    public List<int> SetEffectdaidaihoho()
    {
        return listEffectdaidaihoho;
    }

    public List<int> SetEffectkaomakka()
    {
        return listEffectkaomakka;
    }

    public List<int> SetEffectwaruikage()
    {
        return listEffectwaruikage;
    }

    public List<string> Setreturntext1()
    {
        //   Debug.Log("受け渡しているテキストの中身" + listSerihu[1]);
        return listreturntext1;
    }

    public List<string> Setreturntext2()
    {
        //   Debug.Log("受け渡しているテキストの中身" + listSerihu[1]);
        return listreturntext2;
    }

    public List<int> Setreturnflag()
    {
        //   Debug.Log("受け渡しているテキストの中身" + listSerihu[1]);
        return returnflag;
    }

    public int Monnyou(int cycle)
    {
        return listMonnyou[cycle];
    }
    public void randomchat(string url,int firstcnt,int finishcnt)
    {
        //ランダム数値の計算
        var rand = new System.Random();

        int value = rand.Next(firstcnt, finishcnt);
        Debug.Log("random:" + value);
        textclear();
        reader = new StreamReader(File.OpenRead(url));//ランダム描いてあるCSVからとってくる
        while (!reader.EndOfStream)
        {        //readflagの値がランダム数値に合致した範囲だけ台詞を取得する
            var line = reader.ReadLine();
            var values = line.Split(',');
            if (values[0] != "serihu" && int.Parse(values[10]) == value)
            {

                listSerihu.Add(values[0]);
                listEye.Add(int.Parse(values[1]));
                listMouth.Add(int.Parse(values[2]));
                listMayuge.Add(int.Parse(values[3]));
                listMonnyou.Add(int.Parse(values[4]));
                listEffectase.Add(int.Parse(values[5]));
                listEffectakarame.Add(int.Parse(values[6]));
                listEffectdaidaihoho.Add(int.Parse(values[7]));
                listEffectkaomakka.Add(int.Parse(values[8]));
                listEffectwaruikage.Add(int.Parse(values[9]));
                readflag.Add(int.Parse(values[10]));
                if (values[12] == null)
                {
                    values[12] = "";
                }
                listreturntext1.Add(values[12]);
                if (values[13] == null)
                {
                    values[13] = "";
                }
                listreturntext2.Add(values[13]);
                if (values[14] == null)
                {
                    values[14] = "0";
                }
                returnflag.Add(int.Parse(values[14]));
                foreach (var coloumn1 in listSerihu)
                {
                    Console.WriteLine(coloumn1);
                }
            }
        }
        TEXTHYOUZI.setsyorimatiflag(true);
        Debug.Log("setsyorimatiflag:true");
    }
}
