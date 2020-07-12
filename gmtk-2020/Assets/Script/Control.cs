using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{

    //private int finalScore;
    //private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
      //  scoreText = GetComponent<Text>();
       // finalScore = Score.scoreAmount;
    }

    // Update is called once per frame
    void Update()
    {
     //   scoreText.text = "Your Score was: " + finalScore;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Menu");
    }
}
