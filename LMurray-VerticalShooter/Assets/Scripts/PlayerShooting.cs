using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public Rigidbody2D bulletPrefab;
    public float bulletSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(Co_ShootRoutine());
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    // Update is called once per frame
    private void Shoot()
    {
            //shoot bullet
            Rigidbody2D bulletRB = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bulletRB.velocity = -transform.up * bulletSpeed;
            Destroy(bulletRB.gameObject, 4.0f);
    }

    /*IEnumerator Co_ShootRoutine()
    {
        while (true) 
        {
            yield return new WaitForSeconds(0.2f);
            Shoot();
            yield return new WaitForSeconds(0.2f);
            Shoot();
            yield return new WaitForSeconds(0.8f);
            Shoot();
        }
        
    } */
}
