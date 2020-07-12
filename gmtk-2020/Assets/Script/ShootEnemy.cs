using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public Transform firePointRight;
    public Transform firePointLeft;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    int i = 0;

    bool right = true;
    // Update is called once per frame
    void Update()
    {
        if (i == 500)
        {
            Shoot();
            i = 0;
        }
        i++;
    }

    void Shoot()
    {
        if (right)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePointRight.position, firePointRight.rotation);
            Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
            rbBullet.AddForce(firePointRight.up * bulletForce, ForceMode2D.Impulse);
            right = false;
        }
        else
        {
            GameObject bullet = Instantiate(bulletPrefab, firePointLeft.position, firePointLeft.rotation);
            Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
            rbBullet.AddForce(firePointLeft.up * bulletForce, ForceMode2D.Impulse);
            right = true;
        }

    }
}
