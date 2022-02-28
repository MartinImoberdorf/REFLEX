using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Botons : MonoBehaviour
{
    AudioSource audioSource;

    private void Awake()
    {
        audioSource=this.GetComponent<AudioSource>();
    }
    // BOTH
    public void Click()
    {
        audioSource.Play();
    }

    // MAIN 0
    public void Quit()
    {
        Application.Quit();
        print("Bye");
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public GameObject sound;

    private void Start()
    {
        DontDestroyOnLoad(sound);
    }

    // MAIN 1

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

}
