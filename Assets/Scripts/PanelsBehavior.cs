using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelsBehavior : MonoBehaviour
{
    [SerializeField] GameObject gamePanel, endPanel;
    [SerializeField] TextMeshProUGUI resultMessage;
    void Start()
    {
        gamePanel.SetActive(true);
        endPanel.SetActive(false);
    }
    
    public void EndGame()
    {
        Time.timeScale = 0f;
        resultMessage.text = "Game over" + "\n" + "You eliminated" + "\n" + 
            FindObjectOfType<Score>().GetResult() + "\n" +  "enemies";
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
    }
}
