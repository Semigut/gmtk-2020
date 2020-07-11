using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFriend : MonoBehaviour
{

    public GameObject hitEffect;
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
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.35f);
            Score.scoreAmount -= 1;
        }



    }
}
