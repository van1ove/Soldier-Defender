using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectionManager : MonoBehaviour
{
    public Button level1, level2, level3;
    private int levelsCompeled;
    void Start()
    {
        levelsCompeled = PlayerPrefs.GetInt("LevelComplete");
        Debug.Log(levelsCompeled);
        level2.interactable = false;
        level3.interactable = false;

        switch(levelsCompeled)
        {
            case 1:
                level2.interactable = true;
                break;
            case 2:
                level2.interactable = true;
                level3.interactable = true;
                break;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void OnBackClicked()
    {
        SceneManager.LoadScene(0);
    }
}
