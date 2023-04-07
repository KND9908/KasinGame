using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kozizentai : MonoBehaviour
{
    Vector2 Positionin;
    [SerializeField] private float huwahuwasyuuha = 2;
    private int frameCnt = 0;
    [SerializeField] private float yurehaba = 1;
    [SerializeField] private float kizyunziku = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Positionin = transform.position;
        frameCnt += 1;
        if (10000 <= frameCnt)
        {
            frameCnt = 0;
        }
        Positionin.y =Mathf.Sin(2.0f * Mathf.PI * (float)(frameCnt / huwahuwasyuuha % 200) / (200.0f - 1.0f)) * yurehaba + kizyunziku;
        Debug.Log(Positionin.y);
        transform.position = Positionin;
    }
}
