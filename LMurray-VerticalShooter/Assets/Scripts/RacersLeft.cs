using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RacersLeft : MonoBehaviour
{
    [SerializeField] private int racersLeft = 40;
    public TextMeshProUGUI racersLeftText;
    [SerializeField] int sceneID;

    private void Start()
    {
        updateText();
    }


    private void updateText()
    {
        racersLeftText.text = "Racers Left:" + racersLeft;
    }

    public void EnemyDestroyed()
    {
        racersLeft--;
        updateText();

        if (racersLeft <= 0)
        {
            SceneManager.LoadScene(sceneID);
        }
    }
}
