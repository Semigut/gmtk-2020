﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }

        if (collision.gameObject.tag.Equals("Friend"))
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }


}
