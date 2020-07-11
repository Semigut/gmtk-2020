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

    

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
        // Destroy(gameObject, lifetime);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();


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

        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;

        rbEnemy.rotation = angle;
    }

    private void FixedUpdate()
    {
        rbEnemy.AddForce(movement * speed);
    }



}
