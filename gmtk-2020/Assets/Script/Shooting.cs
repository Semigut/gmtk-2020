using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    int i = 0;

    // Update is called once per frame
    void Update()
    {
        if (i == 50)
        {
            Shoot();
            i = 0;
        }
        i++;
    }

    void Shoot()
    {
      GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
      rbBullet.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);


    }
}
