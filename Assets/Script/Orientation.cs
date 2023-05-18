using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Orientation : MonoBehaviour
{
    [SerializeField] TMP_Text systemInfoText;
    // Start is called before the first frame update
    void Start()
    {
        systemInfoText.text = "Sensors:";
        if(SystemInfo.supportsAccelerometer)
            systemInfoText.text += "Accelerometer";
        if(SystemInfo.supportsGyroscope)
            systemInfoText.text += "Gyroscope";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
