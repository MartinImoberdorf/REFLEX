using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public List<GameObject> circles;
    public Options options;
    public GameObject chronometer;

    Vector3 pos;
    
    float randomX;
    float randomY;
    public int ballCounter;


    void Start()
    {
        chronometer.SetActive(true);
        ballCounter = options.amount;
        Generate();
        pos = new Vector3();
    }


    void Generate()
    {
        if (ballCounter > 0) {
            int i = Random.Range(0, 4);
            GameObject clon = Instantiate(circles[i]);
            randomX = Random.Range(-7, 7);
            randomY = Random.Range(-4, 4);
            pos.x = randomX;
            pos.y = randomY;
            pos.z = 0;

            clon.transform.position = pos;
            clon.transform.SetParent(this.transform);

            ballCounter--;
            Invoke("Generate", 0.7f);
        }
        

    }

}
