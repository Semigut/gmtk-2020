using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayEasy()
    {
        SceneManager.LoadScene("LevelEasy");
    }

    public void PlayHard()
    {
        SceneManager.LoadScene("LevelHard");
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;

    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

   
}
