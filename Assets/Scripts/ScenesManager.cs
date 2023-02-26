using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIElements;
public class ScenesManager : MonoBehaviour
{
    private Score score;
    private int levelsCompeled;
    void Start()
    {
        score = GetComponent<Score>();
        levelsCompeled = PlayerPrefs.GetInt("LevelComplete");
    }

    void Update()
    {
        PassedLevel();
    }
    private void PassedLevel()
    {
        if(score.GetResult() > 100)
        {
            if(levelsCompeled < 2) levelsCompeled++;
            PlayerPrefs.SetInt("LevelCompleted", levelsCompeled); 
            FindObjectOfType<PanelsBehavior>().CompleteLevel();
        }
    }
}
