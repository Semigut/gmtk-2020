using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{

    SpriteRenderer rend;
    private float lifetime;
    bool fade = true;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        lifetime = Random.Range(3f, 15f);
    }

    // Update is called once per frame
    void Update()
    {

       /* if (Input.GetKeyDown(KeyCode.V))
        {
            StartFading();

        }*/
        if(Time.time >= lifetime)
        {
            
            if (fade)
            {
                StartFading();
                fade = false;
            }
            Destroy(gameObject, lifetime-0.05f);
        }
    }

    private IEnumerator FadeTest ()
    {
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
           
        } 
    }




    public void StartFading()
    {
        
            StartCoroutine("FadeTest");
            
        
    }
}
