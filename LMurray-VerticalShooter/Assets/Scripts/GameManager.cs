using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject[] enemyArray;
    [SerializeField] private List<GameObject> activeEnemyList;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        //activeEnemyList = new List<GameObject>();
        //for (int i = 0; i < enemyArray.Length; i++)
        //{
        //    activeEnemyList.Add(enemyArray[i]);
        //}

        activeEnemyList = new List<GameObject>(enemyArray);
    }

    public void UnlistEnemy(GameObject enemy)
    {
        //for (int i = 0; i < activeEnemyList.Count; i++)
        //{
        //    if (activeEnemyList[i] == enemy)
        //    {
        //        activeEnemyList.RemoveAt(i);
        //        break;
        //    }
        //}
        activeEnemyList.Remove(enemy);
        if (activeEnemyList.Count == 0 )
        {
            StartCoroutine(Co_ResetAllEnemiesDelayed(0.3f));
        }
    }

    private IEnumerator Co_ResetAllEnemiesDelayed(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetAllEnemies();
    }

    private void ResetAllEnemies()
    {
        foreach (var enemy in enemyArray) 
        {
            enemy.GetComponent<Enemy>().Respawn();
            activeEnemyList.Add(enemy);
        }
    }
}