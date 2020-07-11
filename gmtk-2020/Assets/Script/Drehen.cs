using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drehen : MonoBehaviour
{

    Transform myTrans;
    int i = 0;
    int j = 0;

    public float spinRate = 2f;
    float nextSpin = 0f;

    int spin;
    //Vector3 currRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTrans = this.transform;

        if(Time.time > nextSpin)
        {
            spin = Random.Range(1, 5);

            switch (spin)
            {
                case 1:
                    Vector3 currRot1 = myTrans.eulerAngles;
                    currRot1.z += 90;
                    myTrans.eulerAngles = currRot1;
                    break;
                case 2:
                    Vector3 currRot2 = myTrans.eulerAngles;
                    currRot2.z -= 90;
                    myTrans.eulerAngles = currRot2;
                    break;

                case 3:
                    Vector3 currRot3 = myTrans.eulerAngles;
                    currRot3.z += 180;
                    myTrans.eulerAngles = currRot3;
                    break;
                case 4:
                    Vector3 currRot4 = myTrans.eulerAngles;
                    currRot4.z += 180;
                    myTrans.eulerAngles = currRot4;
                    break;

            }

            nextSpin = Time.time + spinRate;
        }

        // int randomzahl = Random.Range(0, 2);
      /*  if (i == 100)
        {
            j++;
            if (j < 10)
            {
                Vector3 currRot = myTrans.eulerAngles;
                currRot.z += 90;
                myTrans.eulerAngles = currRot;
                i = 0;
               
            }
            
            if(j >= 20)
            {

                Vector3 currRot = myTrans.eulerAngles;
                currRot.z -= 90;
                myTrans.eulerAngles = currRot;
                i = 0;
                if(j >= 30)
                {
                    j = 0;
                }   
            }
        }

        i++;*/


    }
}
