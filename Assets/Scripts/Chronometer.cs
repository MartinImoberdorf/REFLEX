using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{
    public Text timeText;
    public float time = 0.0f;
    public bool pause = false;
    

    private void Update()
    {
        OnPause();

        if (pause != true)
        {
            time = time + 1 * Time.deltaTime;
        }
        
        timeText.text = "" + time;
    }

    public void OnPause()
    {
        if (GameManager.INSTANCIA.total_a_destruir == 0)
        {
            pause = true;
        }
        
    }
}
