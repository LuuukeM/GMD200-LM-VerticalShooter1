using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private float respawnY = -6;
    private float _respawnX;

    void Start()
    {
        _respawnX = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(true);
    }

    public void Respawn()
    {
        gameObject.SetActive(true );
        transform.position = new Vector2(_respawnX, respawnY);
    }

    private void OnMouseDown()
    {
        Debug.Log("down");
        Despawn();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))  
        {
            Despawn();
        }
    }

    private void Despawn()
    {
        gameObject.SetActive(false);
        GameManager.Instance.UnlistEnemy(gameObject);
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
}
