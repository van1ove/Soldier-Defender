using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    private int result;
    void Start()
    {
        score.text = "0";
        result = 0;    
    }

    public void GetPoints()
    {
        result++;
        score.text = result.ToString();
    }

    public int GetResult(){ return result;}
    
}
