using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerReset : MonoBehaviour
{
    void Update()
    {
        Global.Instance.currentTime = 0f;
        Global.Instance.startTime = 100f;
    }
}
