using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hour : MonoBehaviour
{
    Text hourText;

    private void Awake()
    {
        hourText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hourText.text = System.DateTime.Now.Hour.ToString("00") + ":" + System.DateTime.Now.Minute.ToString("00");
    }
}
