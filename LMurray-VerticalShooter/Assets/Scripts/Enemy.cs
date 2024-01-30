using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{ 

    [SerializeField] private float respawnY = -6;
    private float _respawnX;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    void Start()
    {
        _respawnX = transform.position.x;
        transform.position = new Vector2(_respawnX, respawnY);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(true);
        _rigidbody2D.velocity = Vector2.zero;
    }
}
