using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UIElements;
public class PanelsBehavior : MonoBehaviour
{
    [SerializeField] GameObject gamePanel, endPanel, completePanel;
    [SerializeField] TextMeshProUGUI resultMessage;
    private Score score;
    void Start()
    {
        score = GetComponent<Score>();
        gamePanel.SetActive(true);
        endPanel.SetActive(false);
        completePanel.SetActive(false);
    }
    
    public void EndGame()
    {
        Time.timeScale = 0f;
        resultMessage.text = "Game over" + "\n" + "You eliminated" + "\n" + 
            score.GetResult() + "\n" +  "enemies";
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
    }

    public void CompleteLevel()
    {
        Time.timeScale = 0f;
        gamePanel.SetActive(false);
        endPanel.SetActive(false);
        completePanel.SetActive(true);
    }
}
