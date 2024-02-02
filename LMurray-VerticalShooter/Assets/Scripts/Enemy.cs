using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{ 

    [SerializeField] private float respawnY = -6;
    private float _respawnX;

    private void Awake()
    {

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
    }
}
