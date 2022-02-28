using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    [Header("Options")]
    public GameObject options;
    public GameObject gameManager;
    public int amount;

    public void Option10()
    {
        amount = 10;
        options.SetActive(false);
        gameManager.SetActive(true);
    }
    public void Option15()
    {
        amount = 15;
        options.SetActive(false);
        gameManager.SetActive(true);
    }
    public void Option30()
    {
        amount = 30;
        options.SetActive(false);
        gameManager.SetActive(true);
    }
}
