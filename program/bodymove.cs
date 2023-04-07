using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodymove : MonoBehaviour
{
//    [SerializeField] GameObject GMO;
    [SerializeField] private Vector3 RotatePoint = Vector3.zero;
    [SerializeField] private Vector3 RotateAxis = Vector3.zero;
    [SerializeField] private float _period = 20;
    [SerializeField] private float huwahuwakakudo = 45;
    [SerializeField] private float huwahuwahoukou = 1;
    [SerializeField] private float huwahuwasyuuha = 2;

    private int frameCnt = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        frameCnt += 1;
        if (10000 <= frameCnt)
        {
            frameCnt = 0;
        }
        transform.RotateAround(
        RotatePoint,
        RotateAxis,
        huwahuwakakudo / _period * Mathf.Sin(2.0f * Mathf.PI *(float)(frameCnt / huwahuwasyuuha % 200) / (200.0f - 1.0f))
        );
        //Debug.Log(Mathf.PerlinNoise(frameCnt, 0));
    }
}
