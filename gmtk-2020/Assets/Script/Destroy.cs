using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip deadSound;

    public GameObject hitEffect;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Bullet"))
        {
            sound.PlayOneShot(deadSound);
            Destroy(collision.gameObject);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.35f);
            Score.scoreAmount += 1;
           
        }

        
                
           
        
    }

    
      
    
}
