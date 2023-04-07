using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effectprogram : MonoBehaviour
{
    GameObject ase, hooakarame, daidaihoho, kaomakka, waruikage;
    public SpriteRenderer MainSpriteRenderer;
    public Sprite effect_ase;
    public Sprite effect_hooakarame;
    public Sprite effect_daidaihoho;
    public Sprite effect_kaomakka;
    public Sprite effect_waruikage;
    // Start is called before the first frame update
    void Start()
    {
        ase = GameObject.Find("effect_ase");
        hooakarame = GameObject.Find("effect_akarame");
        daidaihoho = GameObject.Find("effect_daidaihoho");
        kaomakka = GameObject.Find("effectkaomakka");
        waruikage = GameObject.Find("effect_waruikage");

        ase.SetActive(false);
        hooakarame.SetActive(false);
        daidaihoho.SetActive(false);
        kaomakka.SetActive(false);
        waruikage.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChgEffectase(int Useflag)
    {
        Debug.Log("chgeffectase");
        if (Useflag == 1)
        {
            ase.SetActive(true);
        }
        else
        {
            ase.SetActive(false);
        }
    }

    public void ChgEffectakarame(int Useflag)
    {
        if (Useflag == 1)
        {
            hooakarame.SetActive(true);
        }
        else
        {
            hooakarame.SetActive(false);
        }
    }

    public void ChgEffectdaidaihoho(int Useflag)
    {
        if (Useflag == 1)
        {
            daidaihoho.SetActive(true);
        }
        else
        {
            daidaihoho.SetActive(false);
        }
    }

    public void Chgkaomakka(int Useflag)
    {
        if (Useflag == 1)
        {
            kaomakka.SetActive(true);
        }
        else
        {
            kaomakka.SetActive(false);
        }
    }

    public void Chgwaruikage(int Useflag)
    {
        if (Useflag == 1)
        {
            waruikage.SetActive(true);
        }
        else
        {
            waruikage.SetActive(false);
        }
    }
}
