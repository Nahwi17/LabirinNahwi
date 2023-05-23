using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waitCount : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    vid UpdateWaitText(int value)
    {
        text.text = "wait: "  + value + "s";
    }
}
