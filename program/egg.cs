using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    int count = 0;
    int frameCnt = 0;
    [SerializeField] GameObject GMO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameCnt++;
        if (10000 <= frameCnt)
        {
            frameCnt = 0;
        }
        if (count == 8)
        {

        }
        else
        {

        }
    }

    void pushcount()
    {
        count++;
    }
}
