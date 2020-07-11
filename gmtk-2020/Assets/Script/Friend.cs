using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{
    public Rigidbody2D rbEnemy;
    public float accelerationTime = 2f;
    public float speed = 5f;
    private Vector2 movement;
    private float timeLeft;

    public float lifetime;

   
    // Start is called before the first frame update
    void Start()
    {
        lifetime = Random.Range(3f, 10f);
        // Destroy(gameObject, lifetime);
        

        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {

            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;

        }
      

    }

    private void FixedUpdate()
    {
        rbEnemy.AddForce(movement * speed);
    }



}
