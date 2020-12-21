using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireing : MonoBehaviour
{
    public Transform Bambam;
    public GameObject bulletPrefab;
    //need new prefab

    public float bulletF = 20f;
    void Update()
    {
        // fire1 does not valid anymore
        if (Input.GetButtonDown("Fire1"))
        { 
            shoot(); 
        }

    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, Bambam.position, Bambam.rotation);
        Rigidbody2D Ragdoll = bullet.GetComponent<Rigidbody2D>();
        Ragdoll.AddForce(Bambam.up * bulletF, ForceMode2D.Impulse);
    }
}
