using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager INSTANCIA;

    [Header("Record")]
    public Chronometer chronometer;
    public Text textRecord;
    public float record10;
    public float record15;
    public float record30;
    public int activeRecord;

    [Header("Statistics")]
    public GameObject scoreViewObject;
    public Text remainingBalls;
    public GameObject chronometerObject;
    public GameObject remainingBallsObject;
    public Text scoreTime;
    

    [Header("Initial Counter")]
    public GameObject generator;
    public Text counter;
    public GameObject counterObject;
    public bool ready = false;
    float tiempo = 3f;
 
    [Header("Extras")]
    public int total_a_destruir;
    public bool destruido = true;
    public Options option;

    
    
    private void Awake()
    {
        total_a_destruir = option.amount;

        scoreViewObject.SetActive(false);
        counterObject.SetActive(true);
        remainingBallsObject.SetActive(true);

        ActiveRecord();
    }
    private void Start()
    {
        counter.text = "" + tiempo;

        INSTANCIA = this;
        if (option.amount == 10)
        {
            record10 = PlayerPrefs.GetFloat("Record10");
            textRecord.text = record10.ToString();
        }
        if (option.amount == 15)
        {
            record15 = PlayerPrefs.GetFloat("Record15");
            textRecord.text = record15.ToString();
        }
        if (option.amount == 30)
        {
            record30 = PlayerPrefs.GetFloat("Record30");
            textRecord.text = record30.ToString();
        }

    }

    private void Update()
    {
        remainingBalls.text=total_a_destruir.ToString();

        if (tiempo == 0)
        {
            CancelInvoke("ContadorInicial");
            counter = null;
        }
        else
        {
            InitialCounter();
        }
        
        

        if (total_a_destruir == 0)
        {
            IsRecord();
            Score();
        }
        
    }

    public void IsRecord()
    {
        if (option.amount == 10)
        {
            if (chronometer.time < record10)
            {
                record10 = chronometer.time;
                PlayerPrefs.SetFloat("Record10", record10);
                textRecord.text = record10.ToString();
            }
        }
        if (option.amount == 15)
        {
            if (chronometer.time < record15)
            {
                record15 = chronometer.time;
                PlayerPrefs.SetFloat("Record15", record15);
                textRecord.text = record15.ToString();
            }
        }
        if (option.amount == 30)
        {
            if (chronometer.time < record30)
            {
                record30 = chronometer.time;
                PlayerPrefs.SetFloat("Record30", record10);
                textRecord.text = record30.ToString();
            }
        }


    }

    public void Destroyed()
    {
        total_a_destruir--;
    }

    void InitialCounter()
    {

        tiempo -= Time.deltaTime;
        counter.text = " " + tiempo.ToString("f0");

        if (tiempo <= 0)
        {
            ready = true;
            generator.SetActive(true);
            counter.gameObject.SetActive(false);
        }
    }

    public void Score()
    {
        scoreTime.text = chronometer.time.ToString();
        scoreViewObject.SetActive(true);
        chronometerObject.SetActive(false);
        remainingBallsObject.SetActive(false);
    }

    public void ActiveRecord()
    {
        activeRecord = PlayerPrefs.GetInt("activaRecord");

        if (activeRecord == 0)
        {
            PlayerPrefs.SetFloat("Record10", 100);
            PlayerPrefs.SetFloat("Record15", 100);
            PlayerPrefs.SetFloat("Record30", 100);

            activeRecord = PlayerPrefs.GetInt("activaRecord");
            PlayerPrefs.SetInt("activaRecord", 1);
        }
    }
}
