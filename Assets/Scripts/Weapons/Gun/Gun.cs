using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform barrel;
    public GameObject bullet;

    float nextTimeToFire = 1f;

    float fireRate = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || (Input.GetMouseButton(0) && Time.time >= nextTimeToFire))
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            // if (ammoClip > 0)
            Shoot();
        }
    }

    private void Shoot()
    {       
        GameObject newBullet = Instantiate(bullet, barrel.position, barrel.localRotation);
        
        newBullet.GetComponent<Rigidbody>().velocity = barrel.forward * 45f;

        Destroy(newBullet, 2f);
    }
}
