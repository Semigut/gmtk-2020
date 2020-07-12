using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    int i = 0;
    public GameObject hitEffect;

    Vector2 movement;
    Transform myTrans;


    private void Start()
    {
        myTrans = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


    }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
       

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("BulletEnemy"))
        {

            Leben.liveAmount -= 1;

            if (Leben.liveAmount == 0)
            {
                FindObjectOfType<SoundManager>().Play("Dead");
                Destroy(collision.gameObject);
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Destroy(effect, 0.35f);
                SceneManager.LoadScene(3);
            
            }
        }



    }

}
