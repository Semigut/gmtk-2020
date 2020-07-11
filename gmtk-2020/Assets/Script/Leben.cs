using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leben : MonoBehaviour
{
    public static int liveAmount;
    private Text liveText;

    // Start is called before the first frame update
    void Start()
    {
        liveText = GetComponent<Text>();
        liveAmount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        liveText.text = "Live: " + liveAmount;
    }
}
