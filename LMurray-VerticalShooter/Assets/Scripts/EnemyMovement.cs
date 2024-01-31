using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class joncode : MonoBehaviour
{

    int carX;
    private Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Random test = new Random();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(0, 0.001f, 0);
        checkForDriving();

    }

    void checkForDriving()
    {

        if (transform.position.x <= -1f)
        {
            rb.AddForce(new Vector2(1, 0) * speed);
        }
        else if (transform.position.x >= 1f)
        {
            rb.AddForce(new Vector2(-1, 0) * speed);
        }
        else
        {
            carX = Random.Range(-5, 6);
            rb.AddForce(new Vector2(carX, 0) * speed);
        }
    }
}