using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBehavior : MonoBehaviour
{
    private const int SelectionSceneIndex = 1;
    public void OnRetryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void OnExitClick()
    {
        SceneManager.LoadScene(SelectionSceneIndex);
    }

    public void OnReturnClick()
    {
        PlayerPrefs.SetInt("LevelComplete", PlayerPrefs.GetInt("LevelComplete") + 1);
        SceneManager.LoadScene(SelectionSceneIndex);
    }
}
