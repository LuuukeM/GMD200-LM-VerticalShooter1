using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private float respawnY = -6;
    [SerializeField] int sceneID;
    private float _respawnX;
    RacersLeft racersLeft;

    void Start()
    {
        racersLeft = GameObject.FindGameObjectWithTag("RacersLeftText").GetComponent<RacersLeft>();
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
        Despawn();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))  
        {
            Despawn();
        }

        if (other.gameObject.CompareTag("LoseBox"))
        {
            SceneManager.LoadScene(sceneID);
        }
    }

    private void Despawn()
    {
        racersLeft.EnemyDestroyed();
        gameObject.SetActive(false);
        GameManager.Instance.UnlistEnemy(gameObject);
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
}
