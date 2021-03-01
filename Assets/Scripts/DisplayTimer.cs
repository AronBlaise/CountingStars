using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTimer : MonoBehaviour
{
    [SerializeField] Text CDtext;
    private void Update()
    {
        CDtext.text = Global.Instance.currentTime.ToString("0");
    }

}
