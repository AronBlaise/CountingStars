using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float cT=0f, sT=100f;
    void Start()
    {
        cT = Global.Instance.currentTime;
        sT = Global.Instance.startTime;
        cT = sT;
    }
    void Update()
    {
        cT -= 1 * Time.deltaTime;
        if (cT <= 0)
        {
            cT = 0;
        }
        Global.Instance.currentTime = cT;
        Global.Instance.startTime = cT;
    }

}
