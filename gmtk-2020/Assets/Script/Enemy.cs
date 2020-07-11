using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D rbEnemy;
    Transform myTrans;
    public float myWidth;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTrans = this.transform;
        rbEnemy = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 myVel = rbEnemy.velocity;
        myVel.y = speed;
        rbEnemy.velocity = myVel;
    }
}
